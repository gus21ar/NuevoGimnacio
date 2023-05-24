namespace Miselaneas
{
	partial class FRedesAdd
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRedesAdd));
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
			label1.Location = new Point(111, 9);
			label1.Margin = new Padding(8, 0, 8, 0);
			label1.Name = "label1";
			label1.Size = new Size(566, 72);
			label1.TabIndex = 10;
			label1.Text = "Agregar Red Social";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Georgia", 24F, FontStyle.Regular, GraphicsUnit.Point);
			label2.Location = new Point(17, 113);
			label2.Margin = new Padding(8, 0, 8, 0);
			label2.Name = "label2";
			label2.Size = new Size(143, 38);
			label2.TabIndex = 11;
			label2.Text = "Nombre:";
			// 
			// txtNombre
			// 
			txtNombre.BackColor = Color.DarkGray;
			txtNombre.Font = new Font("Georgia", 24F, FontStyle.Regular, GraphicsUnit.Point);
			txtNombre.ForeColor = Color.White;
			txtNombre.Location = new Point(176, 110);
			txtNombre.Margin = new Padding(8);
			txtNombre.Name = "txtNombre";
			txtNombre.Size = new Size(587, 44);
			txtNombre.TabIndex = 0;
			txtNombre.TextAlign = HorizontalAlignment.Center;
			// 
			// btnAgregar
			// 
			btnAgregar.BackColor = Color.OliveDrab;
			btnAgregar.Font = new Font("Georgia", 24F, FontStyle.Regular, GraphicsUnit.Point);
			btnAgregar.Location = new Point(17, 192);
			btnAgregar.Margin = new Padding(8);
			btnAgregar.Name = "btnAgregar";
			btnAgregar.Size = new Size(746, 164);
			btnAgregar.TabIndex = 1;
			btnAgregar.Text = "Agregar";
			btnAgregar.UseVisualStyleBackColor = false;
			btnAgregar.Click += btnAgregar_Click;
			// 
			// FRedesAdd
			// 
			AcceptButton = btnAgregar;
			AutoScaleDimensions = new SizeF(19F, 38F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.DimGray;
			ClientSize = new Size(784, 391);
			Controls.Add(btnAgregar);
			Controls.Add(txtNombre);
			Controls.Add(label2);
			Controls.Add(label1);
			ForeColor = Color.White;
			FormBorderStyle = FormBorderStyle.Fixed3D;
			Icon = (Icon)resources.GetObject("$this.Icon");
			Margin = new Padding(8);
			Name = "FRedesAdd";
			ShowIcon = false;
			StartPosition = FormStartPosition.CenterParent;
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