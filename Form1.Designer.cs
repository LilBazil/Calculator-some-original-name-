namespace Calculator_some_original_name_
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonPlusMinus = new System.Windows.Forms.Button();
            this.buttonZero = new System.Windows.Forms.Button();
            this.buttonPoint = new System.Windows.Forms.Button();
            this.buttonThree = new System.Windows.Forms.Button();
            this.buttonTwo = new System.Windows.Forms.Button();
            this.buttonOne = new System.Windows.Forms.Button();
            this.buttonSix = new System.Windows.Forms.Button();
            this.buttonFive = new System.Windows.Forms.Button();
            this.buttonFour = new System.Windows.Forms.Button();
            this.buttonNine = new System.Windows.Forms.Button();
            this.buttonEight = new System.Windows.Forms.Button();
            this.buttonSeven = new System.Windows.Forms.Button();
            this.buttonDivide = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonMultiple = new System.Windows.Forms.Button();
            this.buttonPercent = new System.Windows.Forms.Button();
            this.buttonRoot = new System.Windows.Forms.Button();
            this.buttonSquare = new System.Windows.Forms.Button();
            this.buttonReverse = new System.Windows.Forms.Button();
            this.buttonCE = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonEquils = new System.Windows.Forms.Button();
            this.rtbHistory = new System.Windows.Forms.RichTextBox();
            this.buttonClearHistory = new System.Windows.Forms.Button();
            this.lblShowOp = new System.Windows.Forms.Label();
            this.lblHIstoryDisplay = new System.Windows.Forms.Label();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.buttonMC = new System.Windows.Forms.Button();
            this.buttonMR = new System.Windows.Forms.Button();
            this.buttonMS = new System.Windows.Forms.Button();
            this.buttonMPlus = new System.Windows.Forms.Button();
            this.buttonMMinus = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPlusMinus
            // 
            this.buttonPlusMinus.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonPlusMinus.FlatAppearance.BorderSize = 0;
            this.buttonPlusMinus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonPlusMinus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonPlusMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlusMinus.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlusMinus.Location = new System.Drawing.Point(6, 472);
            this.buttonPlusMinus.Name = "buttonPlusMinus";
            this.buttonPlusMinus.Size = new System.Drawing.Size(80, 80);
            this.buttonPlusMinus.TabIndex = 0;
            this.buttonPlusMinus.Text = "+/-";
            this.buttonPlusMinus.UseVisualStyleBackColor = false;
            this.buttonPlusMinus.Click += new System.EventHandler(this.changeSign);
            // 
            // buttonZero
            // 
            this.buttonZero.BackColor = System.Drawing.Color.Turquoise;
            this.buttonZero.FlatAppearance.BorderSize = 0;
            this.buttonZero.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.buttonZero.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonZero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZero.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonZero.Location = new System.Drawing.Point(92, 472);
            this.buttonZero.Name = "buttonZero";
            this.buttonZero.Size = new System.Drawing.Size(80, 80);
            this.buttonZero.TabIndex = 1;
            this.buttonZero.Text = "0";
            this.buttonZero.UseVisualStyleBackColor = false;
            this.buttonZero.Click += new System.EventHandler(this.numbersOn);
            // 
            // buttonPoint
            // 
            this.buttonPoint.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonPoint.FlatAppearance.BorderSize = 0;
            this.buttonPoint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonPoint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonPoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPoint.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPoint.Location = new System.Drawing.Point(178, 472);
            this.buttonPoint.Name = "buttonPoint";
            this.buttonPoint.Size = new System.Drawing.Size(80, 80);
            this.buttonPoint.TabIndex = 2;
            this.buttonPoint.Text = ",";
            this.buttonPoint.UseVisualStyleBackColor = false;
            this.buttonPoint.Click += new System.EventHandler(this.numbersOn);
            // 
            // buttonThree
            // 
            this.buttonThree.BackColor = System.Drawing.Color.Turquoise;
            this.buttonThree.FlatAppearance.BorderSize = 0;
            this.buttonThree.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.buttonThree.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonThree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonThree.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThree.Location = new System.Drawing.Point(178, 386);
            this.buttonThree.Name = "buttonThree";
            this.buttonThree.Size = new System.Drawing.Size(80, 80);
            this.buttonThree.TabIndex = 5;
            this.buttonThree.Text = "3";
            this.buttonThree.UseVisualStyleBackColor = false;
            this.buttonThree.Click += new System.EventHandler(this.numbersOn);
            // 
            // buttonTwo
            // 
            this.buttonTwo.BackColor = System.Drawing.Color.Turquoise;
            this.buttonTwo.FlatAppearance.BorderSize = 0;
            this.buttonTwo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.buttonTwo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTwo.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTwo.Location = new System.Drawing.Point(92, 386);
            this.buttonTwo.Name = "buttonTwo";
            this.buttonTwo.Size = new System.Drawing.Size(80, 80);
            this.buttonTwo.TabIndex = 4;
            this.buttonTwo.Text = "2";
            this.buttonTwo.UseVisualStyleBackColor = false;
            this.buttonTwo.Click += new System.EventHandler(this.numbersOn);
            // 
            // buttonOne
            // 
            this.buttonOne.BackColor = System.Drawing.Color.Turquoise;
            this.buttonOne.FlatAppearance.BorderSize = 0;
            this.buttonOne.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.buttonOne.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOne.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOne.Location = new System.Drawing.Point(6, 386);
            this.buttonOne.Name = "buttonOne";
            this.buttonOne.Size = new System.Drawing.Size(80, 80);
            this.buttonOne.TabIndex = 3;
            this.buttonOne.Text = "1";
            this.buttonOne.UseVisualStyleBackColor = false;
            this.buttonOne.Click += new System.EventHandler(this.numbersOn);
            // 
            // buttonSix
            // 
            this.buttonSix.BackColor = System.Drawing.Color.Turquoise;
            this.buttonSix.FlatAppearance.BorderSize = 0;
            this.buttonSix.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.buttonSix.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonSix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSix.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSix.Location = new System.Drawing.Point(178, 300);
            this.buttonSix.Name = "buttonSix";
            this.buttonSix.Size = new System.Drawing.Size(80, 80);
            this.buttonSix.TabIndex = 8;
            this.buttonSix.Text = "6";
            this.buttonSix.UseVisualStyleBackColor = false;
            this.buttonSix.Click += new System.EventHandler(this.numbersOn);
            // 
            // buttonFive
            // 
            this.buttonFive.BackColor = System.Drawing.Color.Turquoise;
            this.buttonFive.FlatAppearance.BorderSize = 0;
            this.buttonFive.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.buttonFive.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonFive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFive.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFive.Location = new System.Drawing.Point(92, 300);
            this.buttonFive.Name = "buttonFive";
            this.buttonFive.Size = new System.Drawing.Size(80, 80);
            this.buttonFive.TabIndex = 7;
            this.buttonFive.Text = "5";
            this.buttonFive.UseVisualStyleBackColor = false;
            this.buttonFive.Click += new System.EventHandler(this.numbersOn);
            // 
            // buttonFour
            // 
            this.buttonFour.BackColor = System.Drawing.Color.Turquoise;
            this.buttonFour.FlatAppearance.BorderSize = 0;
            this.buttonFour.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.buttonFour.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonFour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFour.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFour.Location = new System.Drawing.Point(6, 300);
            this.buttonFour.Name = "buttonFour";
            this.buttonFour.Size = new System.Drawing.Size(80, 80);
            this.buttonFour.TabIndex = 6;
            this.buttonFour.Text = "4";
            this.buttonFour.UseVisualStyleBackColor = false;
            this.buttonFour.Click += new System.EventHandler(this.numbersOn);
            // 
            // buttonNine
            // 
            this.buttonNine.BackColor = System.Drawing.Color.Turquoise;
            this.buttonNine.FlatAppearance.BorderSize = 0;
            this.buttonNine.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.buttonNine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonNine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNine.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNine.Location = new System.Drawing.Point(178, 214);
            this.buttonNine.Name = "buttonNine";
            this.buttonNine.Size = new System.Drawing.Size(80, 80);
            this.buttonNine.TabIndex = 11;
            this.buttonNine.Text = "9";
            this.buttonNine.UseVisualStyleBackColor = false;
            this.buttonNine.Click += new System.EventHandler(this.numbersOn);
            // 
            // buttonEight
            // 
            this.buttonEight.BackColor = System.Drawing.Color.Turquoise;
            this.buttonEight.FlatAppearance.BorderSize = 0;
            this.buttonEight.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.buttonEight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonEight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEight.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEight.Location = new System.Drawing.Point(92, 214);
            this.buttonEight.Name = "buttonEight";
            this.buttonEight.Size = new System.Drawing.Size(80, 80);
            this.buttonEight.TabIndex = 10;
            this.buttonEight.Text = "8";
            this.buttonEight.UseVisualStyleBackColor = false;
            this.buttonEight.Click += new System.EventHandler(this.numbersOn);
            // 
            // buttonSeven
            // 
            this.buttonSeven.BackColor = System.Drawing.Color.Turquoise;
            this.buttonSeven.FlatAppearance.BorderSize = 0;
            this.buttonSeven.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.buttonSeven.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonSeven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSeven.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSeven.Location = new System.Drawing.Point(6, 214);
            this.buttonSeven.Name = "buttonSeven";
            this.buttonSeven.Size = new System.Drawing.Size(80, 80);
            this.buttonSeven.TabIndex = 9;
            this.buttonSeven.Text = "7";
            this.buttonSeven.UseVisualStyleBackColor = false;
            this.buttonSeven.Click += new System.EventHandler(this.numbersOn);
            // 
            // buttonDivide
            // 
            this.buttonDivide.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonDivide.FlatAppearance.BorderSize = 0;
            this.buttonDivide.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonDivide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonDivide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDivide.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDivide.Location = new System.Drawing.Point(264, 214);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(80, 80);
            this.buttonDivide.TabIndex = 15;
            this.buttonDivide.Text = "/";
            this.buttonDivide.UseVisualStyleBackColor = false;
            this.buttonDivide.Click += new System.EventHandler(this.operatorsClick);
            // 
            // buttonMinus
            // 
            this.buttonMinus.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonMinus.FlatAppearance.BorderSize = 0;
            this.buttonMinus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonMinus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinus.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMinus.Location = new System.Drawing.Point(264, 300);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(80, 80);
            this.buttonMinus.TabIndex = 14;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = false;
            this.buttonMinus.Click += new System.EventHandler(this.operatorsClick);
            // 
            // buttonPlus
            // 
            this.buttonPlus.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonPlus.FlatAppearance.BorderSize = 0;
            this.buttonPlus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonPlus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlus.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlus.Location = new System.Drawing.Point(264, 386);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(80, 80);
            this.buttonPlus.TabIndex = 13;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = false;
            this.buttonPlus.Click += new System.EventHandler(this.operatorsClick);
            // 
            // buttonMultiple
            // 
            this.buttonMultiple.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonMultiple.FlatAppearance.BorderSize = 0;
            this.buttonMultiple.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonMultiple.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonMultiple.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMultiple.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMultiple.Location = new System.Drawing.Point(264, 472);
            this.buttonMultiple.Name = "buttonMultiple";
            this.buttonMultiple.Size = new System.Drawing.Size(80, 80);
            this.buttonMultiple.TabIndex = 12;
            this.buttonMultiple.Text = "*";
            this.buttonMultiple.UseVisualStyleBackColor = false;
            this.buttonMultiple.Click += new System.EventHandler(this.operatorsClick);
            // 
            // buttonPercent
            // 
            this.buttonPercent.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonPercent.FlatAppearance.BorderSize = 0;
            this.buttonPercent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonPercent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonPercent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPercent.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPercent.Location = new System.Drawing.Point(350, 214);
            this.buttonPercent.Name = "buttonPercent";
            this.buttonPercent.Size = new System.Drawing.Size(80, 80);
            this.buttonPercent.TabIndex = 19;
            this.buttonPercent.Text = "%";
            this.buttonPercent.UseVisualStyleBackColor = false;
            this.buttonPercent.Click += new System.EventHandler(this.operatorsClick);
            // 
            // buttonRoot
            // 
            this.buttonRoot.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonRoot.FlatAppearance.BorderSize = 0;
            this.buttonRoot.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonRoot.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonRoot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRoot.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRoot.Location = new System.Drawing.Point(350, 300);
            this.buttonRoot.Name = "buttonRoot";
            this.buttonRoot.Size = new System.Drawing.Size(80, 80);
            this.buttonRoot.TabIndex = 18;
            this.buttonRoot.Text = "√";
            this.buttonRoot.UseVisualStyleBackColor = false;
            this.buttonRoot.Click += new System.EventHandler(this.operatorsClick);
            // 
            // buttonSquare
            // 
            this.buttonSquare.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonSquare.FlatAppearance.BorderSize = 0;
            this.buttonSquare.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonSquare.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonSquare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSquare.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSquare.Location = new System.Drawing.Point(350, 386);
            this.buttonSquare.Name = "buttonSquare";
            this.buttonSquare.Size = new System.Drawing.Size(80, 80);
            this.buttonSquare.TabIndex = 17;
            this.buttonSquare.Text = "^";
            this.buttonSquare.UseVisualStyleBackColor = false;
            this.buttonSquare.Click += new System.EventHandler(this.operatorsClick);
            // 
            // buttonReverse
            // 
            this.buttonReverse.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonReverse.FlatAppearance.BorderSize = 0;
            this.buttonReverse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonReverse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonReverse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReverse.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReverse.Location = new System.Drawing.Point(350, 472);
            this.buttonReverse.Name = "buttonReverse";
            this.buttonReverse.Size = new System.Drawing.Size(80, 80);
            this.buttonReverse.TabIndex = 16;
            this.buttonReverse.Text = "1/x";
            this.buttonReverse.UseVisualStyleBackColor = false;
            this.buttonReverse.Click += new System.EventHandler(this.operatorsClick);
            // 
            // buttonCE
            // 
            this.buttonCE.BackColor = System.Drawing.Color.SandyBrown;
            this.buttonCE.FlatAppearance.BorderSize = 0;
            this.buttonCE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.buttonCE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.buttonCE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCE.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCE.Location = new System.Drawing.Point(6, 173);
            this.buttonCE.Name = "buttonCE";
            this.buttonCE.Size = new System.Drawing.Size(80, 35);
            this.buttonCE.TabIndex = 20;
            this.buttonCE.Text = "CE";
            this.buttonCE.UseVisualStyleBackColor = false;
            this.buttonCE.Click += new System.EventHandler(this.buttonCE_Click);
            // 
            // buttonC
            // 
            this.buttonC.BackColor = System.Drawing.Color.SandyBrown;
            this.buttonC.FlatAppearance.BorderSize = 0;
            this.buttonC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.buttonC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.buttonC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonC.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonC.Location = new System.Drawing.Point(92, 173);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(80, 35);
            this.buttonC.TabIndex = 21;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = false;
            this.buttonC.Click += new System.EventHandler(this.buttonC_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.SandyBrown;
            this.buttonBack.FlatAppearance.BorderSize = 0;
            this.buttonBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.buttonBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(178, 173);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(80, 35);
            this.buttonBack.TabIndex = 22;
            this.buttonBack.Text = "<-";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.cancelInput);
            // 
            // buttonEquils
            // 
            this.buttonEquils.BackColor = System.Drawing.Color.SandyBrown;
            this.buttonEquils.FlatAppearance.BorderSize = 0;
            this.buttonEquils.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.buttonEquils.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.buttonEquils.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEquils.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEquils.Location = new System.Drawing.Point(264, 173);
            this.buttonEquils.Name = "buttonEquils";
            this.buttonEquils.Size = new System.Drawing.Size(165, 35);
            this.buttonEquils.TabIndex = 23;
            this.buttonEquils.Text = "=";
            this.buttonEquils.UseVisualStyleBackColor = false;
            this.buttonEquils.Click += new System.EventHandler(this.buttonEquils_Click);
            // 
            // rtbHistory
            // 
            this.rtbHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(0)))), ((int)(((byte)(49)))));
            this.rtbHistory.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbHistory.ForeColor = System.Drawing.SystemColors.Info;
            this.rtbHistory.Location = new System.Drawing.Point(436, 130);
            this.rtbHistory.Name = "rtbHistory";
            this.rtbHistory.Size = new System.Drawing.Size(327, 424);
            this.rtbHistory.TabIndex = 24;
            this.rtbHistory.Text = "";
            // 
            // buttonClearHistory
            // 
            this.buttonClearHistory.BackColor = System.Drawing.Color.SandyBrown;
            this.buttonClearHistory.FlatAppearance.BorderSize = 0;
            this.buttonClearHistory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.buttonClearHistory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.buttonClearHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearHistory.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearHistory.Location = new System.Drawing.Point(634, 514);
            this.buttonClearHistory.Name = "buttonClearHistory";
            this.buttonClearHistory.Size = new System.Drawing.Size(120, 35);
            this.buttonClearHistory.TabIndex = 25;
            this.buttonClearHistory.Text = "clear";
            this.buttonClearHistory.UseVisualStyleBackColor = false;
            this.buttonClearHistory.Click += new System.EventHandler(this.buttonClearHistory_Click);
            // 
            // lblShowOp
            // 
            this.lblShowOp.AutoSize = true;
            this.lblShowOp.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowOp.ForeColor = System.Drawing.SystemColors.Info;
            this.lblShowOp.Location = new System.Drawing.Point(12, 18);
            this.lblShowOp.Name = "lblShowOp";
            this.lblShowOp.Size = new System.Drawing.Size(0, 29);
            this.lblShowOp.TabIndex = 26;
            this.lblShowOp.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblShowOp.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblHIstoryDisplay
            // 
            this.lblHIstoryDisplay.AutoSize = true;
            this.lblHIstoryDisplay.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHIstoryDisplay.ForeColor = System.Drawing.SystemColors.Info;
            this.lblHIstoryDisplay.Location = new System.Drawing.Point(451, 145);
            this.lblHIstoryDisplay.Name = "lblHIstoryDisplay";
            this.lblHIstoryDisplay.Size = new System.Drawing.Size(148, 17);
            this.lblHIstoryDisplay.TabIndex = 27;
            this.lblHIstoryDisplay.Text = "No history yet";
            this.lblHIstoryDisplay.Click += new System.EventHandler(this.lblHIstoryDisplay_Click);
            // 
            // txtDisplay
            // 
            this.txtDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(0)))), ((int)(((byte)(49)))));
            this.txtDisplay.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay.ForeColor = System.Drawing.SystemColors.Info;
            this.txtDisplay.Location = new System.Drawing.Point(6, 64);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(424, 60);
            this.txtDisplay.TabIndex = 28;
            this.txtDisplay.Text = "0";
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDisplay.TextChanged += new System.EventHandler(this.txtDisplay_TextChanged);
            // 
            // buttonMC
            // 
            this.buttonMC.BackColor = System.Drawing.Color.SandyBrown;
            this.buttonMC.FlatAppearance.BorderSize = 0;
            this.buttonMC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.buttonMC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.buttonMC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMC.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMC.Location = new System.Drawing.Point(6, 132);
            this.buttonMC.Name = "buttonMC";
            this.buttonMC.Size = new System.Drawing.Size(80, 35);
            this.buttonMC.TabIndex = 29;
            this.buttonMC.Text = "MC";
            this.buttonMC.UseVisualStyleBackColor = false;
            this.buttonMC.Click += new System.EventHandler(this.operatorsClickMC);
            // 
            // buttonMR
            // 
            this.buttonMR.BackColor = System.Drawing.Color.SandyBrown;
            this.buttonMR.FlatAppearance.BorderSize = 0;
            this.buttonMR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.buttonMR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.buttonMR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMR.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMR.Location = new System.Drawing.Point(92, 132);
            this.buttonMR.Name = "buttonMR";
            this.buttonMR.Size = new System.Drawing.Size(80, 35);
            this.buttonMR.TabIndex = 30;
            this.buttonMR.Text = "MR";
            this.buttonMR.UseVisualStyleBackColor = false;
            this.buttonMR.Click += new System.EventHandler(this.operatorsClickMR);
            // 
            // buttonMS
            // 
            this.buttonMS.BackColor = System.Drawing.Color.SandyBrown;
            this.buttonMS.FlatAppearance.BorderSize = 0;
            this.buttonMS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.buttonMS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.buttonMS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMS.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMS.Location = new System.Drawing.Point(178, 132);
            this.buttonMS.Name = "buttonMS";
            this.buttonMS.Size = new System.Drawing.Size(80, 35);
            this.buttonMS.TabIndex = 31;
            this.buttonMS.Text = "MS";
            this.buttonMS.UseVisualStyleBackColor = false;
            this.buttonMS.Click += new System.EventHandler(this.operatorsClickMS);
            // 
            // buttonMPlus
            // 
            this.buttonMPlus.BackColor = System.Drawing.Color.SandyBrown;
            this.buttonMPlus.FlatAppearance.BorderSize = 0;
            this.buttonMPlus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.buttonMPlus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.buttonMPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMPlus.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMPlus.Location = new System.Drawing.Point(264, 132);
            this.buttonMPlus.Name = "buttonMPlus";
            this.buttonMPlus.Size = new System.Drawing.Size(80, 35);
            this.buttonMPlus.TabIndex = 32;
            this.buttonMPlus.Text = "M+";
            this.buttonMPlus.UseVisualStyleBackColor = false;
            this.buttonMPlus.Click += new System.EventHandler(this.operatorsClickMPlus);
            // 
            // buttonMMinus
            // 
            this.buttonMMinus.BackColor = System.Drawing.Color.SandyBrown;
            this.buttonMMinus.FlatAppearance.BorderSize = 0;
            this.buttonMMinus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.buttonMMinus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.buttonMMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMMinus.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMMinus.Location = new System.Drawing.Point(350, 132);
            this.buttonMMinus.Name = "buttonMMinus";
            this.buttonMMinus.Size = new System.Drawing.Size(80, 35);
            this.buttonMMinus.TabIndex = 33;
            this.buttonMMinus.Text = "M-";
            this.buttonMMinus.UseVisualStyleBackColor = false;
            this.buttonMMinus.Click += new System.EventHandler(this.operatorsClickMMinus);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(436, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 99);
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.ErrorImage")));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(658, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(105, 99);
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.ErrorImage")));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.InitialImage")));
            this.pictureBox3.Location = new System.Drawing.Point(547, 25);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(105, 99);
            this.pictureBox3.TabIndex = 36;
            this.pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonMMinus);
            this.Controls.Add(this.buttonMPlus);
            this.Controls.Add(this.buttonMS);
            this.Controls.Add(this.buttonMR);
            this.Controls.Add(this.buttonMC);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.lblHIstoryDisplay);
            this.Controls.Add(this.lblShowOp);
            this.Controls.Add(this.buttonClearHistory);
            this.Controls.Add(this.rtbHistory);
            this.Controls.Add(this.buttonEquils);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.buttonCE);
            this.Controls.Add(this.buttonPercent);
            this.Controls.Add(this.buttonRoot);
            this.Controls.Add(this.buttonSquare);
            this.Controls.Add(this.buttonReverse);
            this.Controls.Add(this.buttonDivide);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.buttonMultiple);
            this.Controls.Add(this.buttonNine);
            this.Controls.Add(this.buttonEight);
            this.Controls.Add(this.buttonSeven);
            this.Controls.Add(this.buttonSix);
            this.Controls.Add(this.buttonFive);
            this.Controls.Add(this.buttonFour);
            this.Controls.Add(this.buttonThree);
            this.Controls.Add(this.buttonTwo);
            this.Controls.Add(this.buttonOne);
            this.Controls.Add(this.buttonPoint);
            this.Controls.Add(this.buttonZero);
            this.Controls.Add(this.buttonPlusMinus);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.Text = "тут есть креветка";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPlusMinus;
        private System.Windows.Forms.Button buttonZero;
        private System.Windows.Forms.Button buttonPoint;
        private System.Windows.Forms.Button buttonThree;
        private System.Windows.Forms.Button buttonTwo;
        private System.Windows.Forms.Button buttonOne;
        private System.Windows.Forms.Button buttonSix;
        private System.Windows.Forms.Button buttonFive;
        private System.Windows.Forms.Button buttonFour;
        private System.Windows.Forms.Button buttonNine;
        private System.Windows.Forms.Button buttonEight;
        private System.Windows.Forms.Button buttonSeven;
        private System.Windows.Forms.Button buttonDivide;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonMultiple;
        private System.Windows.Forms.Button buttonPercent;
        private System.Windows.Forms.Button buttonRoot;
        private System.Windows.Forms.Button buttonSquare;
        private System.Windows.Forms.Button buttonReverse;
        private System.Windows.Forms.Button buttonCE;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonEquils;
        private System.Windows.Forms.RichTextBox rtbHistory;
        private System.Windows.Forms.Button buttonClearHistory;
        private System.Windows.Forms.Label lblShowOp;
        private System.Windows.Forms.Label lblHIstoryDisplay;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button buttonMC;
        private System.Windows.Forms.Button buttonMR;
        private System.Windows.Forms.Button buttonMS;
        private System.Windows.Forms.Button buttonMPlus;
        private System.Windows.Forms.Button buttonMMinus;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

