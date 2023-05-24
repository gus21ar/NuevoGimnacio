namespace Miselaneas
{
	partial class FAyuda
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FAyuda));
			lblpri = new Label();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			SuspendLayout();
			// 
			// lblpri
			// 
			lblpri.AutoSize = true;
			lblpri.Font = new Font("Georgia", 24F, FontStyle.Regular, GraphicsUnit.Point);
			lblpri.ForeColor = Color.White;
			lblpri.Location = new Point(17, 222);
			lblpri.Margin = new Padding(8, 0, 8, 0);
			lblpri.Name = "lblpri";
			lblpri.Size = new Size(225, 38);
			lblpri.TabIndex = 0;
			lblpri.Text = "GusSoluciones";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Georgia", 24F, FontStyle.Regular, GraphicsUnit.Point);
			label1.ForeColor = Color.White;
			label1.Location = new Point(316, 222);
			label1.Margin = new Padding(8, 0, 8, 0);
			label1.Name = "label1";
			label1.Size = new Size(311, 38);
			label1.TabIndex = 1;
			label1.Text = "Gus21ar@gmail.com";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Georgia", 24F, FontStyle.Regular, GraphicsUnit.Point);
			label2.ForeColor = Color.GreenYellow;
			label2.Location = new Point(17, 297);
			label2.Margin = new Padding(8, 0, 8, 0);
			label2.Name = "label2";
			label2.Size = new Size(187, 38);
			label2.TabIndex = 2;
			label2.Text = "Tecnotronic";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Georgia", 24F, FontStyle.Regular, GraphicsUnit.Point);
			label3.ForeColor = Color.GreenYellow;
			label3.Location = new Point(240, 297);
			label3.Margin = new Padding(8, 0, 8, 0);
			label3.Name = "label3";
			label3.Size = new Size(460, 38);
			label3.TabIndex = 3;
			label3.Text = "Patagones 305 (223 501-9653) ";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.ForeColor = Color.Orange;
			label4.Location = new Point(17, 117);
			label4.Name = "label4";
			label4.Size = new Size(819, 38);
			label4.TabIndex = 5;
			label4.Text = "Si presiona 'Alt+M' se puede ver el munú de la aplicación";
			// 
			// FAyuda
			// 
			AutoScaleDimensions = new SizeF(19F, 38F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.DimGray;
			ClientSize = new Size(837, 539);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(lblpri);
			FormBorderStyle = FormBorderStyle.Fixed3D;
			Icon = (Icon)resources.GetObject("$this.Icon");
			Margin = new Padding(8);
			Name = "FAyuda";
			StartPosition = FormStartPosition.Manual;
			Text = "Contacto";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblpri;
		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
	}
}