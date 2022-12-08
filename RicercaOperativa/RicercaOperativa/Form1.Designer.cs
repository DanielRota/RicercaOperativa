namespace RicercaOperativa
{
    partial class RicercaOperativa
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle61 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle62 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle63 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle64 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle65 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mainDataGridView = new System.Windows.Forms.DataGridView();
            this.buttonFillRandomly = new System.Windows.Forms.Button();
            this.buttonResume = new System.Windows.Forms.Button();
            this.groupBoxMethods = new System.Windows.Forms.GroupBox();
            this.radioButtonMinimumCosts = new System.Windows.Forms.RadioButton();
            this.radioButtonNorthWest = new System.Windows.Forms.RadioButton();
            this.buttonResolve = new System.Windows.Forms.Button();
            this.richTextBoxProcess = new System.Windows.Forms.RichTextBox();
            this.panelBackgroundColor = new System.Windows.Forms.Panel();
            this.groupBoxMatrix = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownOperativeUnits = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDestinations = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCreateGrid = new System.Windows.Forms.Button();
            this.groupBoxSettings = new System.Windows.Forms.GroupBox();
            this.groupBoxSpeed = new System.Windows.Forms.GroupBox();
            this.trackBarSpeed = new System.Windows.Forms.TrackBar();
            this.groupBoxButtons = new System.Windows.Forms.GroupBox();
            this.buttonReload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataGridView)).BeginInit();
            this.groupBoxMethods.SuspendLayout();
            this.panelBackgroundColor.SuspendLayout();
            this.groupBoxMatrix.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOperativeUnits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDestinations)).BeginInit();
            this.groupBoxSettings.SuspendLayout();
            this.groupBoxSpeed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).BeginInit();
            this.groupBoxButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainDataGridView
            // 
            this.mainDataGridView.AllowUserToAddRows = false;
            this.mainDataGridView.AllowUserToDeleteRows = false;
            this.mainDataGridView.AllowUserToResizeColumns = false;
            this.mainDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle61.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.mainDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle61;
            this.mainDataGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mainDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.mainDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mainDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle62.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle62.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle62.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle62.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle62.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle62.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle62.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mainDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle62;
            this.mainDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainDataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle63.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle63.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle63.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle63.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle63.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle63.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle63.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle63.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mainDataGridView.DefaultCellStyle = dataGridViewCellStyle63;
            this.mainDataGridView.GridColor = System.Drawing.Color.LightGray;
            this.mainDataGridView.Location = new System.Drawing.Point(14, 294);
            this.mainDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mainDataGridView.MultiSelect = false;
            this.mainDataGridView.Name = "mainDataGridView";
            this.mainDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle64.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle64.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle64.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle64.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle64.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle64.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.mainDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle64;
            this.mainDataGridView.RowHeadersVisible = false;
            this.mainDataGridView.RowHeadersWidth = 45;
            this.mainDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle65.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle65.Padding = new System.Windows.Forms.Padding(2);
            this.mainDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle65;
            this.mainDataGridView.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(2);
            this.mainDataGridView.RowTemplate.Height = 25;
            this.mainDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mainDataGridView.Size = new System.Drawing.Size(168, 142);
            this.mainDataGridView.StandardTab = true;
            this.mainDataGridView.TabIndex = 1;
            this.mainDataGridView.Visible = false;
            this.mainDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.mainDataGridView_CellValueChanged);
            this.mainDataGridView.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.Grid_EditingControlShowing);
            // 
            // buttonFillRandomly
            // 
            this.buttonFillRandomly.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonFillRandomly.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFillRandomly.Enabled = false;
            this.buttonFillRandomly.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonFillRandomly.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.buttonFillRandomly.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.buttonFillRandomly.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumBlue;
            this.buttonFillRandomly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFillRandomly.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFillRandomly.ForeColor = System.Drawing.Color.White;
            this.buttonFillRandomly.Location = new System.Drawing.Point(125, 32);
            this.buttonFillRandomly.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonFillRandomly.Name = "buttonFillRandomly";
            this.buttonFillRandomly.Size = new System.Drawing.Size(100, 66);
            this.buttonFillRandomly.TabIndex = 5;
            this.buttonFillRandomly.Text = "Riempi";
            this.buttonFillRandomly.UseVisualStyleBackColor = false;
            this.buttonFillRandomly.Click += new System.EventHandler(this.buttonFillRandomly_Click);
            // 
            // buttonResume
            // 
            this.buttonResume.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonResume.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonResume.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonResume.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.buttonResume.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.buttonResume.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumBlue;
            this.buttonResume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonResume.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonResume.ForeColor = System.Drawing.Color.White;
            this.buttonResume.Location = new System.Drawing.Point(445, 32);
            this.buttonResume.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonResume.Name = "buttonResume";
            this.buttonResume.Size = new System.Drawing.Size(100, 66);
            this.buttonResume.TabIndex = 7;
            this.buttonResume.Text = "Ripristina";
            this.buttonResume.UseVisualStyleBackColor = false;
            this.buttonResume.Click += new System.EventHandler(this.buttonResume_Click);
            // 
            // groupBoxMethods
            // 
            this.groupBoxMethods.Controls.Add(this.radioButtonMinimumCosts);
            this.groupBoxMethods.Controls.Add(this.radioButtonNorthWest);
            this.groupBoxMethods.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBoxMethods.Enabled = false;
            this.groupBoxMethods.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBoxMethods.Location = new System.Drawing.Point(232, 39);
            this.groupBoxMethods.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxMethods.Name = "groupBoxMethods";
            this.groupBoxMethods.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxMethods.Size = new System.Drawing.Size(165, 98);
            this.groupBoxMethods.TabIndex = 3;
            this.groupBoxMethods.TabStop = false;
            this.groupBoxMethods.Text = "Metodi di Risoluzione";
            // 
            // radioButtonMinimumCosts
            // 
            this.radioButtonMinimumCosts.AutoSize = true;
            this.radioButtonMinimumCosts.BackColor = System.Drawing.SystemColors.Window;
            this.radioButtonMinimumCosts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonMinimumCosts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonMinimumCosts.Location = new System.Drawing.Point(18, 60);
            this.radioButtonMinimumCosts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonMinimumCosts.Name = "radioButtonMinimumCosts";
            this.radioButtonMinimumCosts.Size = new System.Drawing.Size(122, 24);
            this.radioButtonMinimumCosts.TabIndex = 2;
            this.radioButtonMinimumCosts.TabStop = true;
            this.radioButtonMinimumCosts.Text = "Minimi Costi";
            this.radioButtonMinimumCosts.UseVisualStyleBackColor = false;
            this.radioButtonMinimumCosts.CheckedChanged += new System.EventHandler(this.radioButtonMinimumCosts_CheckedChanged);
            // 
            // radioButtonNorthWest
            // 
            this.radioButtonNorthWest.AutoSize = true;
            this.radioButtonNorthWest.BackColor = System.Drawing.SystemColors.Window;
            this.radioButtonNorthWest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonNorthWest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonNorthWest.Location = new System.Drawing.Point(18, 28);
            this.radioButtonNorthWest.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonNorthWest.Name = "radioButtonNorthWest";
            this.radioButtonNorthWest.Size = new System.Drawing.Size(125, 24);
            this.radioButtonNorthWest.TabIndex = 0;
            this.radioButtonNorthWest.TabStop = true;
            this.radioButtonNorthWest.Text = "Nord - Ovest";
            this.radioButtonNorthWest.UseVisualStyleBackColor = false;
            this.radioButtonNorthWest.CheckedChanged += new System.EventHandler(this.radioButtonNorthWest_CheckedChanged);
            // 
            // buttonResolve
            // 
            this.buttonResolve.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonResolve.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonResolve.Enabled = false;
            this.buttonResolve.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonResolve.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.buttonResolve.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.buttonResolve.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumBlue;
            this.buttonResolve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonResolve.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonResolve.ForeColor = System.Drawing.Color.White;
            this.buttonResolve.Location = new System.Drawing.Point(231, 32);
            this.buttonResolve.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonResolve.Name = "buttonResolve";
            this.buttonResolve.Size = new System.Drawing.Size(100, 66);
            this.buttonResolve.TabIndex = 6;
            this.buttonResolve.Text = "Risolvi";
            this.buttonResolve.UseVisualStyleBackColor = false;
            this.buttonResolve.Click += new System.EventHandler(this.buttonResolve_Click);
            // 
            // richTextBoxProcess
            // 
            this.richTextBoxProcess.BackColor = System.Drawing.Color.White;
            this.richTextBoxProcess.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxProcess.Location = new System.Drawing.Point(13, 16);
            this.richTextBoxProcess.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.richTextBoxProcess.Name = "richTextBoxProcess";
            this.richTextBoxProcess.ReadOnly = true;
            this.richTextBoxProcess.Size = new System.Drawing.Size(333, 236);
            this.richTextBoxProcess.TabIndex = 8;
            this.richTextBoxProcess.Text = "";
            this.richTextBoxProcess.TextChanged += new System.EventHandler(this.richTextBoxProcess_TextChanged);
            // 
            // panelBackgroundColor
            // 
            this.panelBackgroundColor.BackColor = System.Drawing.Color.White;
            this.panelBackgroundColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBackgroundColor.Controls.Add(this.richTextBoxProcess);
            this.panelBackgroundColor.ForeColor = System.Drawing.Color.Black;
            this.panelBackgroundColor.Location = new System.Drawing.Point(622, 15);
            this.panelBackgroundColor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelBackgroundColor.Name = "panelBackgroundColor";
            this.panelBackgroundColor.Size = new System.Drawing.Size(375, 271);
            this.panelBackgroundColor.TabIndex = 9;
            // 
            // groupBoxMatrix
            // 
            this.groupBoxMatrix.Controls.Add(this.label1);
            this.groupBoxMatrix.Controls.Add(this.numericUpDownOperativeUnits);
            this.groupBoxMatrix.Controls.Add(this.numericUpDownDestinations);
            this.groupBoxMatrix.Controls.Add(this.label2);
            this.groupBoxMatrix.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBoxMatrix.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBoxMatrix.Location = new System.Drawing.Point(19, 39);
            this.groupBoxMatrix.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxMatrix.Name = "groupBoxMatrix";
            this.groupBoxMatrix.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxMatrix.Size = new System.Drawing.Size(207, 98);
            this.groupBoxMatrix.TabIndex = 0;
            this.groupBoxMatrix.TabStop = false;
            this.groupBoxMatrix.Text = "Celle Matrice";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unità Operative:";
            // 
            // numericUpDownOperativeUnits
            // 
            this.numericUpDownOperativeUnits.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownOperativeUnits.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownOperativeUnits.Location = new System.Drawing.Point(133, 63);
            this.numericUpDownOperativeUnits.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDownOperativeUnits.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDownOperativeUnits.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownOperativeUnits.Name = "numericUpDownOperativeUnits";
            this.numericUpDownOperativeUnits.Size = new System.Drawing.Size(62, 24);
            this.numericUpDownOperativeUnits.TabIndex = 2;
            this.numericUpDownOperativeUnits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownOperativeUnits.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // numericUpDownDestinations
            // 
            this.numericUpDownDestinations.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownDestinations.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownDestinations.Location = new System.Drawing.Point(133, 34);
            this.numericUpDownDestinations.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDownDestinations.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDownDestinations.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownDestinations.Name = "numericUpDownDestinations";
            this.numericUpDownDestinations.Size = new System.Drawing.Size(62, 24);
            this.numericUpDownDestinations.TabIndex = 3;
            this.numericUpDownDestinations.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownDestinations.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Destinazioni:";
            // 
            // buttonCreateGrid
            // 
            this.buttonCreateGrid.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonCreateGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCreateGrid.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonCreateGrid.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.buttonCreateGrid.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.buttonCreateGrid.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumBlue;
            this.buttonCreateGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateGrid.ForeColor = System.Drawing.Color.White;
            this.buttonCreateGrid.Location = new System.Drawing.Point(19, 32);
            this.buttonCreateGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCreateGrid.Name = "buttonCreateGrid";
            this.buttonCreateGrid.Size = new System.Drawing.Size(100, 66);
            this.buttonCreateGrid.TabIndex = 4;
            this.buttonCreateGrid.Text = "Genera";
            this.buttonCreateGrid.UseVisualStyleBackColor = false;
            this.buttonCreateGrid.Click += new System.EventHandler(this.buttonCreateGrid_Click);
            // 
            // groupBoxSettings
            // 
            this.groupBoxSettings.BackColor = System.Drawing.Color.White;
            this.groupBoxSettings.Controls.Add(this.groupBoxButtons);
            this.groupBoxSettings.Controls.Add(this.groupBoxMethods);
            this.groupBoxSettings.Controls.Add(this.groupBoxMatrix);
            this.groupBoxSettings.Controls.Add(this.groupBoxSpeed);
            this.groupBoxSettings.Location = new System.Drawing.Point(13, 6);
            this.groupBoxSettings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxSettings.Name = "groupBoxSettings";
            this.groupBoxSettings.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxSettings.Size = new System.Drawing.Size(603, 280);
            this.groupBoxSettings.TabIndex = 10;
            this.groupBoxSettings.TabStop = false;
            this.groupBoxSettings.Text = "Impostazioni";
            // 
            // groupBoxSpeed
            // 
            this.groupBoxSpeed.Controls.Add(this.trackBarSpeed);
            this.groupBoxSpeed.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBoxSpeed.Location = new System.Drawing.Point(403, 39);
            this.groupBoxSpeed.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxSpeed.Name = "groupBoxSpeed";
            this.groupBoxSpeed.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxSpeed.Size = new System.Drawing.Size(181, 98);
            this.groupBoxSpeed.TabIndex = 12;
            this.groupBoxSpeed.TabStop = false;
            this.groupBoxSpeed.Text = "Velocità di Esecuzione";
            // 
            // trackBarSpeed
            // 
            this.trackBarSpeed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBarSpeed.LargeChange = 500;
            this.trackBarSpeed.Location = new System.Drawing.Point(8, 34);
            this.trackBarSpeed.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.trackBarSpeed.Maximum = 2500;
            this.trackBarSpeed.Name = "trackBarSpeed";
            this.trackBarSpeed.Size = new System.Drawing.Size(167, 56);
            this.trackBarSpeed.SmallChange = 500;
            this.trackBarSpeed.TabIndex = 11;
            this.trackBarSpeed.TickFrequency = 500;
            this.trackBarSpeed.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarSpeed.Value = 1000;
            this.trackBarSpeed.ValueChanged += new System.EventHandler(this.trackBarSpeed_ValueChanged);
            // 
            // groupBoxButtons
            // 
            this.groupBoxButtons.Controls.Add(this.buttonCreateGrid);
            this.groupBoxButtons.Controls.Add(this.buttonResolve);
            this.groupBoxButtons.Controls.Add(this.buttonFillRandomly);
            this.groupBoxButtons.Controls.Add(this.buttonResume);
            this.groupBoxButtons.Controls.Add(this.buttonReload);
            this.groupBoxButtons.Location = new System.Drawing.Point(19, 146);
            this.groupBoxButtons.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxButtons.Name = "groupBoxButtons";
            this.groupBoxButtons.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxButtons.Size = new System.Drawing.Size(565, 116);
            this.groupBoxButtons.TabIndex = 14;
            this.groupBoxButtons.TabStop = false;
            this.groupBoxButtons.Text = "Funzionalità";
            // 
            // buttonReload
            // 
            this.buttonReload.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonReload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReload.Enabled = false;
            this.buttonReload.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonReload.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.buttonReload.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.buttonReload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumBlue;
            this.buttonReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReload.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReload.ForeColor = System.Drawing.Color.White;
            this.buttonReload.Location = new System.Drawing.Point(338, 32);
            this.buttonReload.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonReload.Name = "buttonReload";
            this.buttonReload.Size = new System.Drawing.Size(100, 66);
            this.buttonReload.TabIndex = 8;
            this.buttonReload.Text = "Recupera";
            this.buttonReload.UseVisualStyleBackColor = false;
            this.buttonReload.Click += new System.EventHandler(this.buttonReload_Click);
            // 
            // RicercaOperativa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1247, 641);
            this.Controls.Add(this.mainDataGridView);
            this.Controls.Add(this.groupBoxSettings);
            this.Controls.Add(this.panelBackgroundColor);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "RicercaOperativa";
            this.Padding = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ricerca Operativa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.mainDataGridView)).EndInit();
            this.groupBoxMethods.ResumeLayout(false);
            this.groupBoxMethods.PerformLayout();
            this.panelBackgroundColor.ResumeLayout(false);
            this.groupBoxMatrix.ResumeLayout(false);
            this.groupBoxMatrix.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOperativeUnits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDestinations)).EndInit();
            this.groupBoxSettings.ResumeLayout(false);
            this.groupBoxSpeed.ResumeLayout(false);
            this.groupBoxSpeed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).EndInit();
            this.groupBoxButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView mainDataGridView;
        private System.Windows.Forms.Button buttonFillRandomly;
        private System.Windows.Forms.GroupBox groupBoxMethods;
        private System.Windows.Forms.RadioButton radioButtonMinimumCosts;
        private System.Windows.Forms.RadioButton radioButtonNorthWest;
        private System.Windows.Forms.Button buttonResolve;
        private System.Windows.Forms.Button buttonResume;
        private System.Windows.Forms.RichTextBox richTextBoxProcess;
        private System.Windows.Forms.Panel panelBackgroundColor;
        private System.Windows.Forms.GroupBox groupBoxMatrix;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCreateGrid;
        private System.Windows.Forms.GroupBox groupBoxSettings;
        private System.Windows.Forms.Button buttonReload;
        private System.Windows.Forms.GroupBox groupBoxSpeed;
        private System.Windows.Forms.TrackBar trackBarSpeed;
        private System.Windows.Forms.GroupBox groupBoxButtons;
        private System.Windows.Forms.NumericUpDown numericUpDownOperativeUnits;
        private System.Windows.Forms.NumericUpDown numericUpDownDestinations;
    }
}
