namespace TrieAutocompleteWinForm
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.ListBox lstSuggestions;
        private System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.Button btnAddWord;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Label lblWord;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lstSuggestions = new System.Windows.Forms.ListBox();
            this.txtWord = new System.Windows.Forms.TextBox();
            this.btnAddWord = new System.Windows.Forms.Button();
            this.lblInput = new System.Windows.Forms.Label();
            this.lblWord = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(20, 20);
            this.lblInput.Text = "Nhập từ khóa:";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(150, 20);
            this.txtInput.Size = new System.Drawing.Size(200, 26);
            // 
            // lstSuggestions
            // 
            this.lstSuggestions.Location = new System.Drawing.Point(150, 60);
            this.lstSuggestions.Size = new System.Drawing.Size(200, 150);
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.Location = new System.Drawing.Point(20, 230);
            this.lblWord.Text = "Thêm từ mới:";
            // 
            // txtWord
            // 
            this.txtWord.Location = new System.Drawing.Point(150, 230);
            this.txtWord.Size = new System.Drawing.Size(200, 26);
            // 
            // btnAddWord
            // 
            this.btnAddWord.Location = new System.Drawing.Point(150, 270);
            this.btnAddWord.Size = new System.Drawing.Size(100, 30);
            this.btnAddWord.Text = "Thêm";
            this.btnAddWord.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(400, 330);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lstSuggestions);
            this.Controls.Add(this.lblWord);
            this.Controls.Add(this.txtWord);
            this.Controls.Add(this.btnAddWord);
            this.Name = "Form1";
            this.Text = "Trie Autocomplete";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
