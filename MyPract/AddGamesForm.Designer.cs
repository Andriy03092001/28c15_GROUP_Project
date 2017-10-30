namespace MyPract
{
    partial class AddGamesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBox_nameOfTournament = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_add_game = new System.Windows.Forms.Button();
            this.txtBox_dateOfTournament = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBox_nameOfTournament
            // 
            this.txtBox_nameOfTournament.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBox_nameOfTournament.Location = new System.Drawing.Point(15, 30);
            this.txtBox_nameOfTournament.Name = "txtBox_nameOfTournament";
            this.txtBox_nameOfTournament.Size = new System.Drawing.Size(410, 26);
            this.txtBox_nameOfTournament.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Назва турніру:";
            // 
            // btn_add_game
            // 
            this.btn_add_game.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_add_game.Location = new System.Drawing.Point(283, 182);
            this.btn_add_game.Name = "btn_add_game";
            this.btn_add_game.Size = new System.Drawing.Size(142, 27);
            this.btn_add_game.TabIndex = 2;
            this.btn_add_game.Text = "Добавити гру";
            this.btn_add_game.UseVisualStyleBackColor = true;
            this.btn_add_game.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBox_dateOfTournament
            // 
            this.txtBox_dateOfTournament.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBox_dateOfTournament.Location = new System.Drawing.Point(15, 87);
            this.txtBox_dateOfTournament.Name = "txtBox_dateOfTournament";
            this.txtBox_dateOfTournament.Size = new System.Drawing.Size(410, 26);
            this.txtBox_dateOfTournament.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Дата проведення:";
            // 
            // AddGamesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 221);
            this.Controls.Add(this.btn_add_game);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBox_dateOfTournament);
            this.Controls.Add(this.txtBox_nameOfTournament);
            this.Name = "AddGamesForm";
            this.Text = "AddGamesForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox_nameOfTournament;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_add_game;
        private System.Windows.Forms.TextBox txtBox_dateOfTournament;
        private System.Windows.Forms.Label label2;
    }
}