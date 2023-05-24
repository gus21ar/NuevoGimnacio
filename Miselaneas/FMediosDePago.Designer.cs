namespace Miselaneas
{
	partial class FMediosDePago
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMediosDePago));
			label1 = new Label();
			label2 = new Label();
			txtNombre = new TextBox();
			btnAgregar = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Georgia", 48F, FontStyle.Regular, GraphicsUnit.Point);
			label1.ForeColor = Color.White;
			label1.Location = new Point(12, 9);
			label1.Name = "label1";
			label1.Size = new Size(715, 72);
			label1.TabIndex = 0;
			label1.Text = "Agregar Medios de Pago";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.ForeColor = Color.White;
			label2.Location = new Point(12, 136);
			label2.Name = "label2";
			label2.Size = new Size(143, 38);
			label2.TabIndex = 1;
			label2.Text = "Nombre:";
			// 
			// txtNombre
			// 
			txtNombre.BackColor = Color.DarkGray;
			txtNombre.ForeColor = Color.White;
			txtNombre.Location = new Point(161, 136);
			txtNombre.Name = "txtNombre";
			txtNombre.Size = new Size(561, 44);
			txtNombre.TabIndex = 2;
			txtNombre.TextAlign = HorizontalAlignment.Center;
			// 
			// btnAgregar
			// 
			btnAgregar.BackColor = Color.OliveDrab;
			btnAgregar.ForeColor = Color.White;
			btnAgregar.Location = new Point(12, 220);
			btnAgregar.Name = "btnAgregar";
			btnAgregar.Size = new Size(715, 179);
			btnAgregar.TabIndex = 3;
			btnAgregar.Text = "Agregar";
			btnAgregar.UseVisualStyleBackColor = false;
			btnAgregar.Click += btnAgregar_Click;
			// 
			// FMediosDePago
			// 
			AutoScaleDimensions = new SizeF(19F, 38F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.DimGray;
			ClientSize = new Size(734, 411);
			Controls.Add(btnAgregar);
			Controls.Add(txtNombre);
			Controls.Add(label2);
			Controls.Add(label1);
			FormBorderStyle = FormBorderStyle.Fixed3D;
			Icon = (Icon)resources.GetObject("$this.Icon");
			Margin = new Padding(8);
			Name = "FMediosDePago";
			StartPosition = FormStartPosition.CenterParent;
			Text = "Agregar Medios De Pago";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private TextBox txtNombre;
		private Button btnAgregar;
	}
}