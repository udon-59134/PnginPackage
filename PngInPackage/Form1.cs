using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PngInPackage
{
    public partial class Form1 : Form
    {
        // ファイルサイズ上限(3MB)
        private const int FILESIZE_LIMIT = 3000000;
        // 選択する画像ファイルのフルパス(ファイル名含む)
        private string inputFullFilePath = "";
        // 埋め込みするファイルのフルパス(ファイル名含む)
        private string embeddedFullFilePath = "";
        // 出力する画像ファイルのフルパス(ファイル名含む)
        private string outputFullFilePath = "";
        // EXEファイルのディレクトリパス
        private string exeFullFilePath = "";
        private const string EXEFILE = "pack.exe";

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 埋め込み対象となる画像ファイルの選択を行う
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PngRefButton_Click(object sender, EventArgs e)
        {
            if(SelectPngFileDialog.ShowDialog() == DialogResult.OK)
            {
                // 選択したファイル名をラベルに反映する
                FileNameLabel1.Text = SelectPngFileDialog.FileName;
                inputFullFilePath = SelectPngFileDialog.FileName;

                // 選択したファイル名からファイル名のみを取得(拡張子無し)
                string inputFileNameNoExt = Path.GetFileNameWithoutExtension(inputFullFilePath);
                // 選択したファイル名から拡張子のみを取得
                string inputFileNameExt = Path.GetExtension(inputFullFilePath);
                // 出力するファイル名を生成する
                string outputFileName = inputFileNameNoExt + "_ex" + inputFileNameExt;
                // 編集用のテキストボックスに生成した出力するファイル名を表示
                outputFileNameText.Text = outputFileName;
            }
        }
        /// <summary>
        /// 埋め込む対象のファイルの選択を行う
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FileRefButton_Click(object sender, EventArgs e)
        {
            if (SelectAllFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileInfo fileInfo = null;
                // 選択したファイルからファイルサイズを取得する
                try
                {
                    fileInfo = new FileInfo(SelectAllFileDialog.FileName);
                    
                }
                catch (IOException ioex)
                {
                    MessageBox.Show(ioex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //MessageBox.Show(fileInfo.Length.ToString());
                // ファイルサイズが3MB以上ならエラーにする
                if (fileInfo.Length > FILESIZE_LIMIT)
                {
                    MessageBox.Show("埋め込む対象のファイルに3MB以上のデータは指定できません", "ファイルサイズの上限エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    // 選択したファイル名をラベルに反映する
                    FileNameLabel2.Text = SelectAllFileDialog.FileName;
                    // 埋め込むファイル名を格納する
                    embeddedFullFilePath = SelectAllFileDialog.FileName;
                }
            }
        }
        /// <summary>
        /// コマンドを組み立てて実行する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            bool error_flg = false;
            List<string> error_msg_list = new List<string>();

            // 選択する画像ファイル名が空の場合、エラーとする
            if(inputFullFilePath == "")
            {
                error_msg_list.Add("・埋め込み対象となる画像のファイル名がありません。");
                error_flg = true;
            }

            // 埋め込むファイル名が空の場合、エラーとする
            if(embeddedFullFilePath == "")
            {
                error_msg_list.Add("・埋め込む対象となるデータのファイル名がありません。");
                error_flg = true;

            }

            // 出力ファイル名が空の場合、エラーとする
            if (outputFileNameText.Text == "")
            {
                error_msg_list.Add("・出力する対象となる画像のファイル名がありません。");
                error_flg = true;
            }

            if (error_flg)
            {
                string error_msg = string.Join("\n", error_msg_list);
                MessageBox.Show(error_msg, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // EXEファイルが格納されているファイルパスを組み立てる
            exeFullFilePath = Path.GetDirectoryName(Application.ExecutablePath) + "\\" + EXEFILE;
            // 出力するファイル名を組み立てる
            outputFullFilePath = Path.GetDirectoryName(inputFullFilePath) + "\\" + outputFileNameText.Text;
            // コマンドに必要な要素をリストに入れる
            List<string> commandList = new List<string>();
            commandList.Add(exeFullFilePath);
            commandList.Add(inputFullFilePath);
            commandList.Add(embeddedFullFilePath);
            commandList.Add(outputFullFilePath);

            // コマンドを組み立てる
            string command = string.Join(" ", commandList);
            //MessageBox.Show(command);
            //textBox2.Text = command;

            // 使用するexeファイルの存在チェック
            if (!File.Exists(EXEFILE))
            {
                MessageBox.Show(EXEFILE + " が見つかりません。処理を実行できません。", "実行ファイルの不足エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 実行ボタンを無効化
            ExecuteButton.Enabled = false;

            // コンソールを受け取るテキストボックスを初期化
            textBox2.Clear();

            Process p = new Process();
            // コマンドプロンプトと同じように実行します
            p.StartInfo.FileName = System.Environment.GetEnvironmentVariable("ComSpec");
            p.StartInfo.Arguments = "/c " + command; // 実行するファイル名（コマンド）

            p.StartInfo.CreateNoWindow = false;   // コンソール・ウィンドウは開かない
            p.StartInfo.UseShellExecute = false; // シェル機能を使用しない
            p.StartInfo.RedirectStandardOutput = true;   // <-- これが「標準出力」リダイレクト

            try
            {
                p.Start();  // コマンドを実行します

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // 実行ボタンを有効化
                ExecuteButton.Enabled = true;
                return;
            }
            // 標準出力に出力しようとした内容を取得して
            // 結果表示用テキストボックスに表示します
            textBox2.Text = p.StandardOutput.ReadToEnd();
            p.WaitForExit();

            MessageBox.Show("処理が完了しました", "完了", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // 実行ボタンを有効化
            ExecuteButton.Enabled = true;
        }

        private void バージョン情報ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string ver = "1.0";
            string author = "萃香うどん";
            string vermsg = String.Format("バージョン: {0}\n作成者: {1}", ver, author);
            MessageBox.Show(vermsg, "情報", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
