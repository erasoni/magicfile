﻿namespace magicfile
{
    partial class FormMain
    {
        /// <summary>
        /// 必要なデザイナ変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナで生成されたコード

        /// <summary>
        /// デザイナ サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディタで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.txtExt = new System.Windows.Forms.TextBox();
            this.txtMime = new System.Windows.Forms.TextBox();
            this.txtMagic = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnNavigate = new System.Windows.Forms.Button();
            this.btnChangeExt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtExt
            // 
            resources.ApplyResources(this.txtExt, "txtExt");
            this.txtExt.Name = "txtExt";
            this.txtExt.ReadOnly = true;
            // 
            // txtMime
            // 
            resources.ApplyResources(this.txtMime, "txtMime");
            this.txtMime.Name = "txtMime";
            this.txtMime.ReadOnly = true;
            // 
            // txtMagic
            // 
            resources.ApplyResources(this.txtMagic, "txtMagic");
            this.txtMagic.Name = "txtMagic";
            this.txtMagic.ReadOnly = true;
            // 
            // btnOK
            // 
            resources.ApplyResources(this.btnOK, "btnOK");
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Name = "btnOK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtFile
            // 
            resources.ApplyResources(this.txtFile, "txtFile");
            this.txtFile.Name = "txtFile";
            this.txtFile.ReadOnly = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // btnNavigate
            // 
            resources.ApplyResources(this.btnNavigate, "btnNavigate");
            this.btnNavigate.Name = "btnNavigate";
            this.btnNavigate.UseVisualStyleBackColor = true;
            this.btnNavigate.Click += new System.EventHandler(this.btnNavigate_Click);
            // 
            // btnChangeExt
            // 
            resources.ApplyResources(this.btnChangeExt, "btnChangeExt");
            this.btnChangeExt.Name = "btnChangeExt";
            this.btnChangeExt.UseVisualStyleBackColor = true;
            this.btnChangeExt.Click += new System.EventHandler(this.btnChangeExt_Click);
            // 
            // FormMain
            // 
            this.AcceptButton = this.btnOK;
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnChangeExt);
            this.Controls.Add(this.btnNavigate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtExt);
            this.Controls.Add(this.txtMime);
            this.Controls.Add(this.txtMagic);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.FormMain_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.FormMain_DragEnter);
            this.DragOver += new System.Windows.Forms.DragEventHandler(this.FormMain_DragOver);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtExt;
        private System.Windows.Forms.TextBox txtMime;
        private System.Windows.Forms.TextBox txtMagic;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnNavigate;
        private System.Windows.Forms.Button btnChangeExt;
    }
}

