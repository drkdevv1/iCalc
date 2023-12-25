namespace iCalc
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbResult = new TextBox();
            btnBorrarTodo = new Circularbttn();
            btnDelete = new Circularbttn();
            btnSigno = new Circularbttn();
            btnDivision = new Circularbttn();
            btnNueve = new Circularbttn();
            btnOcho = new Circularbttn();
            btnSiete = new Circularbttn();
            btnSeis = new Circularbttn();
            btnCinco = new Circularbttn();
            btnCuatro = new Circularbttn();
            btnTres = new Circularbttn();
            btnDos = new Circularbttn();
            btnUno = new Circularbttn();
            btnComa = new Circularbttn();
            btnCero = new Circularbttn2();
            btnMulti = new Circularbttn();
            btnSuma = new Circularbttn();
            btnResta = new Circularbttn();
            btnIgual = new Circularbttn();
            SuspendLayout();
            // 
            // tbResult
            // 
            tbResult.BackColor = SystemColors.ActiveCaptionText;
            tbResult.BorderStyle = BorderStyle.None;
            tbResult.Cursor = Cursors.IBeam;
            tbResult.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbResult.ForeColor = SystemColors.Window;
            tbResult.Location = new Point(3, 132);
            tbResult.MaxLength = 8;
            tbResult.Multiline = true;
            tbResult.Name = "tbResult";
            tbResult.ReadOnly = true;
            tbResult.Size = new Size(318, 92);
            tbResult.TabIndex = 1;
            tbResult.Text = "0";
            tbResult.TextAlign = HorizontalAlignment.Right;
            // 
            // btnBorrarTodo
            // 
            btnBorrarTodo.BackColor = SystemColors.ScrollBar;
            btnBorrarTodo.FlatAppearance.BorderSize = 0;
            btnBorrarTodo.FlatStyle = FlatStyle.Flat;
            btnBorrarTodo.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBorrarTodo.Location = new Point(12, 249);
            btnBorrarTodo.Name = "btnBorrarTodo";
            btnBorrarTodo.Size = new Size(69, 69);
            btnBorrarTodo.TabIndex = 2;
            btnBorrarTodo.TabStop = false;
            btnBorrarTodo.Text = "AC";
            btnBorrarTodo.UseVisualStyleBackColor = false;
            btnBorrarTodo.Click += btnBorrarTodo_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.ScrollBar;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(87, 249);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(69, 69);
            btnDelete.TabIndex = 3;
            btnDelete.TabStop = false;
            btnDelete.Text = "DEL";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSigno
            // 
            btnSigno.BackColor = SystemColors.ScrollBar;
            btnSigno.FlatAppearance.BorderSize = 0;
            btnSigno.FlatStyle = FlatStyle.Flat;
            btnSigno.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSigno.Location = new Point(162, 249);
            btnSigno.Name = "btnSigno";
            btnSigno.Size = new Size(69, 69);
            btnSigno.TabIndex = 4;
            btnSigno.TabStop = false;
            btnSigno.Text = "+/-";
            btnSigno.UseVisualStyleBackColor = false;
            btnSigno.Click += btnSigno_Click;
            // 
            // btnDivision
            // 
            btnDivision.BackColor = Color.FromArgb(255, 159, 10);
            btnDivision.FlatAppearance.BorderSize = 0;
            btnDivision.FlatStyle = FlatStyle.Flat;
            btnDivision.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDivision.ForeColor = SystemColors.ControlLightLight;
            btnDivision.Location = new Point(237, 249);
            btnDivision.Name = "btnDivision";
            btnDivision.Size = new Size(69, 69);
            btnDivision.TabIndex = 5;
            btnDivision.TabStop = false;
            btnDivision.Tag = "/";
            btnDivision.Text = "÷";
            btnDivision.UseVisualStyleBackColor = false;
            btnDivision.Click += Operador_Click;
            // 
            // btnNueve
            // 
            btnNueve.BackColor = SystemColors.WindowFrame;
            btnNueve.FlatAppearance.BorderSize = 0;
            btnNueve.FlatStyle = FlatStyle.Flat;
            btnNueve.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNueve.ForeColor = SystemColors.ControlLightLight;
            btnNueve.Location = new Point(162, 324);
            btnNueve.Name = "btnNueve";
            btnNueve.Size = new Size(69, 69);
            btnNueve.TabIndex = 8;
            btnNueve.TabStop = false;
            btnNueve.Text = "9";
            btnNueve.UseVisualStyleBackColor = false;
            btnNueve.Click += agregar_numero;
            // 
            // btnOcho
            // 
            btnOcho.BackColor = SystemColors.WindowFrame;
            btnOcho.FlatAppearance.BorderSize = 0;
            btnOcho.FlatStyle = FlatStyle.Flat;
            btnOcho.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOcho.ForeColor = SystemColors.ControlLightLight;
            btnOcho.Location = new Point(87, 324);
            btnOcho.Name = "btnOcho";
            btnOcho.Size = new Size(69, 69);
            btnOcho.TabIndex = 7;
            btnOcho.TabStop = false;
            btnOcho.Text = "8";
            btnOcho.UseVisualStyleBackColor = false;
            btnOcho.Click += agregar_numero;
            // 
            // btnSiete
            // 
            btnSiete.BackColor = SystemColors.WindowFrame;
            btnSiete.FlatAppearance.BorderSize = 0;
            btnSiete.FlatStyle = FlatStyle.Flat;
            btnSiete.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSiete.ForeColor = SystemColors.ControlLightLight;
            btnSiete.Location = new Point(12, 324);
            btnSiete.Name = "btnSiete";
            btnSiete.Size = new Size(69, 69);
            btnSiete.TabIndex = 6;
            btnSiete.TabStop = false;
            btnSiete.Text = "7";
            btnSiete.UseVisualStyleBackColor = false;
            btnSiete.Click += agregar_numero;
            // 
            // btnSeis
            // 
            btnSeis.BackColor = SystemColors.WindowFrame;
            btnSeis.FlatAppearance.BorderSize = 0;
            btnSeis.FlatStyle = FlatStyle.Flat;
            btnSeis.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSeis.ForeColor = SystemColors.ControlLightLight;
            btnSeis.Location = new Point(162, 399);
            btnSeis.Name = "btnSeis";
            btnSeis.Size = new Size(69, 69);
            btnSeis.TabIndex = 11;
            btnSeis.TabStop = false;
            btnSeis.Text = "6";
            btnSeis.UseVisualStyleBackColor = false;
            btnSeis.Click += agregar_numero;
            // 
            // btnCinco
            // 
            btnCinco.BackColor = SystemColors.WindowFrame;
            btnCinco.FlatAppearance.BorderSize = 0;
            btnCinco.FlatStyle = FlatStyle.Flat;
            btnCinco.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCinco.ForeColor = SystemColors.ControlLightLight;
            btnCinco.Location = new Point(87, 399);
            btnCinco.Name = "btnCinco";
            btnCinco.Size = new Size(69, 69);
            btnCinco.TabIndex = 10;
            btnCinco.TabStop = false;
            btnCinco.Text = "5";
            btnCinco.UseVisualStyleBackColor = false;
            btnCinco.Click += agregar_numero;
            // 
            // btnCuatro
            // 
            btnCuatro.BackColor = SystemColors.WindowFrame;
            btnCuatro.FlatAppearance.BorderSize = 0;
            btnCuatro.FlatStyle = FlatStyle.Flat;
            btnCuatro.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCuatro.ForeColor = SystemColors.ControlLightLight;
            btnCuatro.Location = new Point(12, 399);
            btnCuatro.Name = "btnCuatro";
            btnCuatro.Size = new Size(69, 69);
            btnCuatro.TabIndex = 9;
            btnCuatro.TabStop = false;
            btnCuatro.Text = "4";
            btnCuatro.UseVisualStyleBackColor = false;
            btnCuatro.Click += agregar_numero;
            // 
            // btnTres
            // 
            btnTres.BackColor = SystemColors.WindowFrame;
            btnTres.FlatAppearance.BorderSize = 0;
            btnTres.FlatStyle = FlatStyle.Flat;
            btnTres.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTres.ForeColor = SystemColors.ControlLightLight;
            btnTres.Location = new Point(162, 474);
            btnTres.Name = "btnTres";
            btnTres.Size = new Size(69, 69);
            btnTres.TabIndex = 14;
            btnTres.TabStop = false;
            btnTres.Text = "3";
            btnTres.UseVisualStyleBackColor = false;
            btnTres.Click += agregar_numero;
            // 
            // btnDos
            // 
            btnDos.BackColor = SystemColors.WindowFrame;
            btnDos.FlatAppearance.BorderSize = 0;
            btnDos.FlatStyle = FlatStyle.Flat;
            btnDos.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDos.ForeColor = SystemColors.ControlLightLight;
            btnDos.Location = new Point(87, 474);
            btnDos.Name = "btnDos";
            btnDos.Size = new Size(69, 69);
            btnDos.TabIndex = 13;
            btnDos.TabStop = false;
            btnDos.Text = "2";
            btnDos.UseVisualStyleBackColor = false;
            btnDos.Click += agregar_numero;
            // 
            // btnUno
            // 
            btnUno.BackColor = SystemColors.WindowFrame;
            btnUno.FlatAppearance.BorderSize = 0;
            btnUno.FlatStyle = FlatStyle.Flat;
            btnUno.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            btnUno.ForeColor = SystemColors.ControlLightLight;
            btnUno.Location = new Point(12, 474);
            btnUno.Name = "btnUno";
            btnUno.Size = new Size(69, 69);
            btnUno.TabIndex = 12;
            btnUno.TabStop = false;
            btnUno.Text = "1";
            btnUno.UseVisualStyleBackColor = false;
            btnUno.Click += agregar_numero;
            // 
            // btnComa
            // 
            btnComa.BackColor = SystemColors.WindowFrame;
            btnComa.FlatAppearance.BorderSize = 0;
            btnComa.FlatStyle = FlatStyle.Flat;
            btnComa.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnComa.ForeColor = SystemColors.ControlLightLight;
            btnComa.Location = new Point(162, 549);
            btnComa.Name = "btnComa";
            btnComa.Size = new Size(69, 69);
            btnComa.TabIndex = 17;
            btnComa.TabStop = false;
            btnComa.Text = ",";
            btnComa.UseVisualStyleBackColor = false;
            btnComa.Click += btnComa_Click;
            // 
            // btnCero
            // 
            btnCero.BackColor = SystemColors.WindowFrame;
            btnCero.FlatAppearance.BorderSize = 0;
            btnCero.FlatStyle = FlatStyle.Flat;
            btnCero.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            btnCero.ForeColor = SystemColors.ControlLightLight;
            btnCero.Location = new Point(12, 549);
            btnCero.Name = "btnCero";
            btnCero.Padding = new Padding(15, 0, 0, 0);
            btnCero.Size = new Size(144, 69);
            btnCero.TabIndex = 18;
            btnCero.TabStop = false;
            btnCero.Text = "0";
            btnCero.TextAlign = ContentAlignment.MiddleLeft;
            btnCero.UseVisualStyleBackColor = false;
            btnCero.Click += agregar_numero;
            // 
            // btnMulti
            // 
            btnMulti.BackColor = Color.FromArgb(255, 159, 10);
            btnMulti.FlatAppearance.BorderSize = 0;
            btnMulti.FlatStyle = FlatStyle.Flat;
            btnMulti.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMulti.ForeColor = SystemColors.ControlLightLight;
            btnMulti.Location = new Point(237, 324);
            btnMulti.Name = "btnMulti";
            btnMulti.Size = new Size(69, 69);
            btnMulti.TabIndex = 19;
            btnMulti.TabStop = false;
            btnMulti.Tag = "X";
            btnMulti.Text = "×";
            btnMulti.UseVisualStyleBackColor = false;
            btnMulti.Click += Operador_Click;
            // 
            // btnSuma
            // 
            btnSuma.BackColor = Color.FromArgb(255, 159, 10);
            btnSuma.FlatAppearance.BorderSize = 0;
            btnSuma.FlatStyle = FlatStyle.Flat;
            btnSuma.Font = new Font("Segoe UI Semibold", 23.75F, FontStyle.Bold);
            btnSuma.ForeColor = SystemColors.ControlLightLight;
            btnSuma.Location = new Point(237, 474);
            btnSuma.Name = "btnSuma";
            btnSuma.Size = new Size(69, 69);
            btnSuma.TabIndex = 21;
            btnSuma.TabStop = false;
            btnSuma.Tag = "+";
            btnSuma.Text = "+";
            btnSuma.UseVisualStyleBackColor = false;
            btnSuma.Click += Operador_Click;
            // 
            // btnResta
            // 
            btnResta.BackColor = Color.FromArgb(255, 159, 10);
            btnResta.FlatAppearance.BorderSize = 0;
            btnResta.FlatStyle = FlatStyle.Flat;
            btnResta.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnResta.ForeColor = SystemColors.ControlLightLight;
            btnResta.Location = new Point(237, 399);
            btnResta.Name = "btnResta";
            btnResta.Size = new Size(69, 69);
            btnResta.TabIndex = 20;
            btnResta.TabStop = false;
            btnResta.Tag = "-";
            btnResta.Text = "-";
            btnResta.UseVisualStyleBackColor = false;
            btnResta.Click += Operador_Click;
            // 
            // btnIgual
            // 
            btnIgual.BackColor = Color.FromArgb(255, 159, 10);
            btnIgual.FlatAppearance.BorderSize = 0;
            btnIgual.FlatStyle = FlatStyle.Flat;
            btnIgual.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIgual.ForeColor = SystemColors.ControlLightLight;
            btnIgual.Location = new Point(237, 549);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(69, 69);
            btnIgual.TabIndex = 22;
            btnIgual.TabStop = false;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = false;
            btnIgual.Click += btnIgual_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(323, 637);
            Controls.Add(btnIgual);
            Controls.Add(btnSuma);
            Controls.Add(btnResta);
            Controls.Add(btnMulti);
            Controls.Add(btnCero);
            Controls.Add(btnComa);
            Controls.Add(btnTres);
            Controls.Add(btnDos);
            Controls.Add(btnUno);
            Controls.Add(btnSeis);
            Controls.Add(btnCinco);
            Controls.Add(btnCuatro);
            Controls.Add(btnNueve);
            Controls.Add(btnOcho);
            Controls.Add(btnSiete);
            Controls.Add(btnDivision);
            Controls.Add(btnSigno);
            Controls.Add(btnDelete);
            Controls.Add(btnBorrarTodo);
            Controls.Add(tbResult);
            Name = "Form1";
            Text = "iCalc";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tbResult;
        private Circularbttn btnBorrarTodo;
        private Circularbttn btnDelete;
        private Circularbttn btnSigno;
        private Circularbttn btnDivision;
        private Circularbttn btnNueve;
        private Circularbttn btnOcho;
        private Circularbttn btnSiete;
        private Circularbttn btnSeis;
        private Circularbttn btnCinco;
        private Circularbttn btnCuatro;
        private Circularbttn btnTres;
        private Circularbttn btnDos;
        private Circularbttn btnUno;
        private Circularbttn btnComa;
        private Circularbttn2 btnCero;
        private Circularbttn btnMulti;
        private Circularbttn btnSuma;
        private Circularbttn btnResta;
        private Circularbttn btnIgual;
        private Circularbttn circularbttn19;
    }
}
