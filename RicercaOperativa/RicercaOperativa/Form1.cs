using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace RicercaOperativa
{
    public partial class RicercaOperativa : Form
    {
        #region Form
        private int speedValue { get; set; } = 1000;
        private bool MainIsEmpty { get; set; } = false;

        private static KeyPressEventHandler NumericCheckHandler = new KeyPressEventHandler(NumericCheck);
        private static DataGridView copyDataGridView = new DataGridView();
        private List<List<int>> _values = new List<List<int>>();
        private Random random = new Random();

        public RicercaOperativa()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }
        #endregion

        #region Eventi
        private void Grid_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (mainDataGridView.CurrentCell.ColumnIndex > 0)
            {
                e.Control.KeyPress -= NumericCheckHandler;
                e.Control.KeyPress += NumericCheckHandler;
            }
        }

        private void mainDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in mainDataGridView.Rows)
            {
                for (var i = 0; i < row.Cells.Count; i++)
                {
                    if (row.Cells[i].Value == null || row.Cells[i].Value == DBNull.Value || String.IsNullOrWhiteSpace(row.Cells[i].Value.ToString()))
                    {
                        MainIsEmpty = true;
                        break;
                    }
                }
            }

            if (!MainIsEmpty)
            {
                groupBoxMethods.Enabled = true;
            }

            MainIsEmpty = false;
        }

        private void buttonCreateGrid_Click(object sender, EventArgs e)
        {
            CreateMatrix(mainDataGridView, (int)numericUpDownOperativeUnits.Value, (int)numericUpDownDestinations.Value);
            CreateMatrix(copyDataGridView, (int)numericUpDownOperativeUnits.Value, (int)numericUpDownDestinations.Value);
            copyDataGridView.Visible = false;

            AllignCells(1);
            DisableRadioButtons();

            copyDataGridView.AllowUserToAddRows = false;
            mainDataGridView.Enabled = true;
            buttonFillRandomly.Enabled = true;
            buttonResolve.Enabled = false;
            buttonReload.Enabled = false;
            groupBoxMethods.Enabled = false;
            richTextBoxProcess.Clear();
        }

        private void buttonFillRandomly_Click(object sender, EventArgs e)
        {
            FillRandomly();

            foreach (DataGridViewRow row in mainDataGridView.Rows)
            {
                for (var i = 0; i < row.Cells.Count; i++)
                {
                    if (row.Cells[i].Value == null || row.Cells[i].Value == DBNull.Value || String.IsNullOrWhiteSpace(row.Cells[i].Value.ToString()))
                    {
                        MainIsEmpty = true;
                        break;
                    }
                }
            }

            if (!MainIsEmpty)
            {
                groupBoxMethods.Enabled = true;
            }

            MainIsEmpty = false;

            mainDataGridView.Enabled = true;
        }

        private void buttonResolve_Click(object sender, EventArgs e)
        {
            var requestProductionTotals = TotalValues();
            DataGridViewCell lastCell = mainDataGridView.Rows[mainDataGridView.RowCount - 1].Cells[mainDataGridView.ColumnCount - 1];

            if (requestProductionTotals.Item1 != AsInt(lastCell.Value))
            {
                MessageBox.Show("La somma delle richieste non corrisponde al totale indicato!", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (requestProductionTotals.Item2 != AsInt(lastCell.Value))
            {
                MessageBox.Show("La somma delle produzioni non corrisponde al totale indicato!", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            groupBoxMethods.Enabled = false;
            mainDataGridView.Enabled = false;
            buttonFillRandomly.Enabled = false;
            buttonCreateGrid.Enabled = false;
            buttonResolve.Enabled = false;
            buttonReload.Enabled = false;
            buttonResume.Enabled = false;

            _values.Clear();

            for (var j = 0; j < mainDataGridView.RowCount; j++)
            {
                _values.Add(new List<int>());

                for (var i = 1; i < mainDataGridView.ColumnCount; i++)
                {
                    _values[j].Add(AsInt(mainDataGridView.Rows[j].Cells[i].Value));
                }
            }

            if (radioButtonNorthWest.Checked)
            {

                var tr = new Thread(new ThreadStart(NorthWestMethod));
                tr.Start();
            }
            else if (radioButtonMinimumCosts.Checked)
            {
                var tr = new Thread(new ThreadStart(MinimumCostsMethod));
                tr.Start();
            }
            else if (radioButtonVogel.Checked)
            {
                var tr = new Thread(new ThreadStart(VogelMethod));
                tr.Start();
            }
            else if (radioButtonRussell.Checked)
            {
                var tr = new Thread(new ThreadStart(RusselMethod));
                tr.Start();
            }
        }

        private void buttonResume_Click(object sender, EventArgs e)
        {
            var _nuds = AllControls(this, typeof(NumericUpDown));

            foreach (Control nud in _nuds)
            {
                NumericUpDown _nud = (NumericUpDown)nud;
                _nud.Value = _nud.Minimum;
            }

            DisableRadioButtons();

            buttonCreateGrid.Enabled = true;
            buttonFillRandomly.Enabled = false;
            buttonReload.Enabled = false;
            mainDataGridView.Enabled = true;
            groupBoxMethods.Enabled = false;
            trackBarSpeed.Value = 1000;
            mainDataGridView.Columns.Clear();
            mainDataGridView.Rows.Clear();
            copyDataGridView.Columns.Clear();
            copyDataGridView.Rows.Clear();
            richTextBoxProcess.Clear();
        }

        private void buttonReload_Click(object sender, EventArgs e)
        {
            ReloadDataGridView();

            buttonFillRandomly.Enabled = true;
        }

        private void radioButtonNorthWest_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioButtonNorthWest.Checked)
            {
                buttonResolve.Enabled = false;
            }
            else
            {
                buttonResolve.Enabled = true;
            }
        }

        private void radioButtonMinimumCosts_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioButtonMinimumCosts.Checked)
            {
                buttonResolve.Enabled = false;
            }
            else
            {
                buttonResolve.Enabled = true;
            }
        }

        private void radioButtonRussell_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioButtonRussell.Checked)
            {
                buttonResolve.Enabled = false;
            }
            else
            {
                buttonResolve.Enabled = true;
            }
        }

        private void radioButtonVogel_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioButtonVogel.Checked)
            {
                buttonResolve.Enabled = false;
            }
            else
            {
                buttonResolve.Enabled = true;
            }
        }

        private void richTextBoxProcess_TextChanged(object sender, EventArgs e)
        {
            richTextBoxProcess.SelectionStart = richTextBoxProcess.Text.Length;
            richTextBoxProcess.ScrollToCaret();
        }

        private void trackBarSpeed_ValueChanged(object sender, EventArgs e)
        {
            speedValue = trackBarSpeed.Value;
        }

        private void RicercaOperativa_ResizeBegin(object sender, EventArgs e)
        {
            mainDataGridView.Location = new Point(14, 294);
        }

        private void RicercaOperativa_ResizeEnd(object sender, EventArgs e)
        {
            mainDataGridView.Location = new Point(14, 294);
        }
        #endregion

        #region GestioneMatrice 
        /// <summary>
        /// Crea un'istanza <see cref="DataGridView"/> con le dimensioni specificate.
        /// </summary>
        /// <param name="columns"> Indica il numero di <see cref="DataGridViewColumn"/> assegnate alla <see cref="DataGridView"/>.</param>
        /// <param name="rows"> Indica il numero di <see cref="DataGridViewRow"/> assegnate alla <see cref="DataGridView"/>.</param>
        private void CreateMatrix(DataGridView dataGridView, int columns, int rows)
        {
            Controls.Remove(dataGridView);
            dataGridView.RowTemplate.Height = 25;
            dataGridView.AutoSize = false;
            dataGridView.Columns.Clear();
            dataGridView.Rows.Clear();
            dataGridView.Columns.Add($"", $"");

            for (var j = 1; j <= columns; j++)
            {
                dataGridView.Columns.Add($"Column{j}", $"D{j}");
                dataGridView.Columns[$"Column{j}"].Width = 80;
            }

            for (var j = 1; j <= rows; j++)
            {
                dataGridView.Rows.Add($"UP{j}");
            }

            dataGridView.Columns.Add("ColumnTotals", "Totali");
            dataGridView.Columns["ColumnTotals"].Width = 80;
            dataGridView.Columns[0].Width = 80;
            dataGridView.Columns[0].ReadOnly = true;
            dataGridView.Rows.Add("Totali");
            dataGridView.Location = new Point(14, 294);
            dataGridView.AutoSize = true;
            dataGridView.Visible = true;
            dataGridView.Columns.Cast<DataGridViewColumn>().ToList().ForEach(x => x.SortMode = DataGridViewColumnSortMode.NotSortable);
            Controls.Add(dataGridView);
        }

        /// <summary>
        /// Riempie le <see cref="DataGridViewCell"/> della <see cref="DataGridView"/> relative ai costi, con numeri <see cref="Int32"/> casuali.
        /// </summary>
        private void FillRandomly()
        {
            var total = random.Next(500, 1000);
            var _requestTotal = RandomDistribution(total, mainDataGridView.RowCount - 1);
            var _productionTotal = RandomDistribution(total, mainDataGridView.ColumnCount - 2);

            for (var j = 0; j < mainDataGridView.RowCount - 1; j++)
            {
                for (var i = 1; i < mainDataGridView.ColumnCount; i++)
                {
                    if (i == mainDataGridView.ColumnCount - 1)
                    {
                        mainDataGridView.Rows[j].Cells[i].Value = _requestTotal[j];
                        copyDataGridView.Rows[j].Cells[i].Value = _requestTotal[j];
                    }
                    else
                    {
                        var value = random.Next(5, 80);
                        mainDataGridView.Rows[j].Cells[i].Value = value;
                        copyDataGridView.Rows[j].Cells[i].Value = value;
                    }
                }
            }

            for (var j = 1; j < mainDataGridView.ColumnCount - 1; j++)
            {
                mainDataGridView.Rows[mainDataGridView.RowCount - 1].Cells[j].Value = _productionTotal[j - 1];
                copyDataGridView.Rows[mainDataGridView.RowCount - 1].Cells[j].Value = _productionTotal[j - 1];
            }

            mainDataGridView.Rows[mainDataGridView.RowCount - 1].Cells[mainDataGridView.ColumnCount - 1].Value = total;
            copyDataGridView.Rows[mainDataGridView.RowCount - 1].Cells[mainDataGridView.ColumnCount - 1].Value = total;
        }

        /// <summary>
        /// Suddivide omogeneamente in N numeri <see cref="Int32"/> un numero <see cref="Int32"/> casuale, aggiunge poi ognuno di essi ad un <see cref="Array"/>.
        /// </summary>
        /// <param name="total"> Indica la somma di richieste e produzioni.</param>
        /// <param name="cells"> Indica il numero di <see cref="DataGridViewCell"/> della <see cref="DataGridView"/> di una determinata <see cref="DataGridViewRow"/> o <see cref="DataGridViewColumn"/>.</param>
        private int[] RandomDistribution(int total, int cells)
        {
            int[] numbers = new int[cells];

            for (var j = 0; j < cells; j++)
            {
                numbers[j] = random.Next((int)Math.Round((double)(total / 100) * 20), total);
            }

            var completeSum = numbers.Sum();

            for (var j = 0; j < cells; j++)
            {
                numbers[j] = (int)(((double)numbers[j] / completeSum) * total);
            }

            var resultSum = numbers.Sum();

            for (var j = 0; j < total - resultSum; j++)
            {
                numbers[random.Next(0, cells)]++;
            }

            return numbers;
        }

        /// <summary>
        /// Ritorna il numero di <see cref="DataGridViewCell"/> della <see cref="DataGridView"/> relative ai costi di trasporto.
        /// </summary>
        private int CellCount()
        {
            var count = 0;

            for (var j = 0; j < mainDataGridView.RowCount - 1; j++)
            {
                for (var i = 1; i < mainDataGridView.ColumnCount - 1; i++)
                {
                    count = count + 1;
                }
            }

            return count;
        }

        /// <summary>
        /// Copia i valori di una <see cref="DataGridViewCell"/> all'interno di un'altra <see cref="DataGridView"/> per valore.
        /// </summary>
        private void ReloadDataGridView()
        {
            mainDataGridView.ColumnCount = copyDataGridView.ColumnCount;
            mainDataGridView.RowCount = copyDataGridView.RowCount;

            for (var j = 0; j < copyDataGridView.RowCount; j++)
            {
                mainDataGridView.Rows[j].Cells[0].Value = copyDataGridView.Rows[j].Cells[0].Value;
                mainDataGridView.Rows[j].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                for (var i = 0; i < copyDataGridView.ColumnCount; i++)
                {
                    mainDataGridView.Columns[i].Name = copyDataGridView.Columns[i].Name;
                    mainDataGridView.Columns[i].HeaderText = copyDataGridView.Columns[i].HeaderText;
                    mainDataGridView.Columns[i].SortMode = copyDataGridView.Columns[i].SortMode;
                    mainDataGridView.Columns[i].ReadOnly = copyDataGridView.Columns[i].ReadOnly;

                    if (i > 0)
                    {
                        mainDataGridView.Rows[j].Cells[i].Value = AsInt(_values[j][i - 1]);
                    }
                }
            }
        }

        /// <summary>
        /// Calcola il totale delle richieste e delle produzioni.
        /// </summary>
        private Tuple<int, int> TotalValues()
        {
            var totalRequest = 0;
            var totalProduction = 0;

            for (var j = 1; j < mainDataGridView.ColumnCount - 1; j++)
            {
                totalRequest += AsInt(mainDataGridView.Rows[mainDataGridView.RowCount - 1].Cells[j].Value);
            }

            for (var j = 0; j < mainDataGridView.RowCount - 1; j++)
            {
                totalProduction += AsInt(mainDataGridView.Rows[j].Cells[mainDataGridView.ColumnCount - 1].Value);
            }

            return new Tuple<int, int>(totalRequest, totalProduction);
        }
        #endregion

        #region MetodoNordOvest
        /// <summary>
        /// Rappresenta uno dei quattro metodi risolutivi del problema, si basa sul calcolo della prima <see cref="DataGridViewCell"/> visibile all'interno della <see cref="DataGridView"/>.
        /// </summary>
        private void NorthWestMethod()
        {
            var totalCost = 0;
            DataGridViewCell firstCell = default;
            DataGridViewCell rowCell = default;
            DataGridViewCell columnCell = default;
            DataGridViewCell lastCell = mainDataGridView.Rows[mainDataGridView.RowCount - 1].Cells[mainDataGridView.ColumnCount - 1];
            Tuple<int, int> totalValues = default;

            richTextBoxProcess.Text += "\n####### METODO NORD-OVEST #######\n\n";

            DisableRadioButtons();

            while (true)
            {
                groupBoxMethods.Enabled = false;

                if (CellCount() == 0)
                {
                    totalCost += AsInt(firstCell.Value) * AsInt(rowCell.Value);
                    richTextBoxProcess.Text += $"Totale: {totalCost}\n";
                    Refresh();
                    break;
                }

                firstCell = mainDataGridView.Rows[0].Cells[1];
                firstCell.Style.BackColor = Color.LightSkyBlue;
                rowCell = mainDataGridView.Rows[mainDataGridView.RowCount - 1].Cells[1];
                columnCell = mainDataGridView.Rows[0].Cells[mainDataGridView.ColumnCount - 1];
                Refresh();
                Thread.Sleep(speedValue);

                if (AsInt(rowCell.Value) < AsInt(columnCell.Value))
                {
                    mainDataGridView.Columns[1].DefaultCellStyle.BackColor = Color.LightSteelBlue;
                    Refresh();
                    Thread.Sleep(speedValue);
                    richTextBoxProcess.Text += $"Da {mainDataGridView.Rows[0].Cells[0].Value} a {mainDataGridView.Columns[1].HeaderText} - Quantità: {rowCell.Value} - Costo: {AsInt(rowCell.Value) * AsInt(firstCell.Value)}\n\n";
                    mainDataGridView.Columns.RemoveAt(1);
                    columnCell.Value = AsInt(columnCell.Value) - AsInt(rowCell.Value);
                    totalCost += AsInt(firstCell.Value) * AsInt(rowCell.Value);
                    Refresh();
                }
                else if (AsInt(rowCell.Value) > AsInt(columnCell.Value))
                {
                    mainDataGridView.Rows[0].DefaultCellStyle.BackColor = Color.LightSteelBlue;
                    mainDataGridView.Rows[0].Cells[0].Style.BackColor = Color.White;
                    Refresh();
                    Thread.Sleep(speedValue);
                    richTextBoxProcess.Text += $"Da {mainDataGridView.Rows[0].Cells[0].Value} a {mainDataGridView.Columns[1].HeaderText} - Quantità: {columnCell.Value} - Costo: {AsInt(columnCell.Value) * AsInt(firstCell.Value)}\n\n";
                    mainDataGridView.Rows.RemoveAt(0);
                    rowCell.Value = AsInt(rowCell.Value) - AsInt(columnCell.Value);
                    totalCost += AsInt(firstCell.Value) * AsInt(columnCell.Value);
                    Refresh();
                }
                else if (AsInt(rowCell.Value) == AsInt(columnCell.Value))
                {
                    mainDataGridView.Columns[1].DefaultCellStyle.BackColor = Color.LightSteelBlue;
                    mainDataGridView.Rows[0].DefaultCellStyle.BackColor = Color.LightSteelBlue;
                    mainDataGridView.Rows[0].Cells[0].Style.BackColor = Color.White;
                    Refresh();
                    Thread.Sleep(speedValue);
                    richTextBoxProcess.Text += $"Da {mainDataGridView.Rows[0].Cells[0].Value} a {mainDataGridView.Columns[1].HeaderText} - Quantità: {columnCell.Value} - Costo: {AsInt(columnCell.Value) * AsInt(firstCell.Value)}\n\n";
                    mainDataGridView.Columns.RemoveAt(1);
                    mainDataGridView.Rows.RemoveAt(0);
                    rowCell.Value = AsInt(rowCell.Value) - AsInt(columnCell.Value);
                    totalCost += AsInt(firstCell.Value) * AsInt(columnCell.Value);
                    Refresh();
                }

                totalValues = TotalValues();
                lastCell.Value = totalValues.Item1;

                if (firstCell == null || rowCell == null || columnCell == null || mainDataGridView == null || richTextBoxProcess == null || lastCell == null || totalValues == null)
                {
                    throw new Exception("Eccezione!");
                }
            }

            mainDataGridView.Enabled = true;
            buttonCreateGrid.Enabled = true;
            buttonReload.Enabled = true;
            buttonResume.Enabled = true;
        }
        #endregion

        #region MetodoMinimiCosti
        /// <summary>
        /// Rappresenta uno dei quattro metodi risolutivi del problema, si basa sul calcolo della <see cref="DataGridViewCell"/> con il valore minore all'interno della <see cref="DataGridView"/>.
        /// </summary>
        private void MinimumCostsMethod()
        {
            var totalCost = 0;
            DataGridViewCell minimumCell = default;
            DataGridViewCell rowCell = default;
            DataGridViewCell columnCell = default;
            DataGridViewRow row = default;
            DataGridViewColumn column = default;
            DataGridViewCell lastCell = mainDataGridView.Rows[mainDataGridView.RowCount - 1].Cells[mainDataGridView.ColumnCount - 1];

            richTextBoxProcess.Text += "\n####### METODO MINIMI COSTI #######\n\n";

            DisableRadioButtons();

            while (true)
            {
                groupBoxMethods.Enabled = false;

                if (CellCount() == 0)
                {
                    richTextBoxProcess.Text += $"Totale: {totalCost}\n";
                    Refresh();
                    break;
                }

                minimumCell = MinimumCell();
                minimumCell.Style.BackColor = Color.Yellow;
                Refresh();
                row = mainDataGridView.Rows[minimumCell.RowIndex];
                column = mainDataGridView.Columns[minimumCell.ColumnIndex];
                rowCell = mainDataGridView.Rows[mainDataGridView.RowCount - 1].Cells[minimumCell.ColumnIndex];
                columnCell = mainDataGridView.Rows[minimumCell.RowIndex].Cells[mainDataGridView.ColumnCount - 1];
                Thread.Sleep(speedValue);
                column.DefaultCellStyle.BackColor = Color.LightGoldenrodYellow;
                row.DefaultCellStyle.BackColor = Color.LightGoldenrodYellow;
                row.Cells[0].Style.BackColor = Color.White;
                Refresh();
                Thread.Sleep(speedValue);

                if (AsInt(rowCell.Value) < AsInt(columnCell.Value))
                {
                    totalCost = totalCost + AsInt(minimumCell.Value) * AsInt(rowCell.Value);
                    columnCell.Value = AsInt(columnCell.Value) - AsInt(rowCell.Value);
                    richTextBoxProcess.Text += $"Da {mainDataGridView.Rows[minimumCell.RowIndex].Cells[0].Value} a {column.HeaderText} - Quantità: {columnCell.Value} - Costo: {AsInt(columnCell.Value) * AsInt(minimumCell.Value)}\n\n";
                    mainDataGridView.Columns.RemoveAt(minimumCell.ColumnIndex);
                    lastCell.Value = AsInt(lastCell.Value) - AsInt(rowCell.Value);
                    Refresh();
                }
                else if (AsInt(rowCell.Value) > AsInt(columnCell.Value))
                {
                    totalCost = totalCost + AsInt(minimumCell.Value) * AsInt(columnCell.Value);
                    rowCell.Value = AsInt(rowCell.Value) - AsInt(columnCell.Value);
                    richTextBoxProcess.Text += $"Da {mainDataGridView.Rows[minimumCell.RowIndex].Cells[0].Value} a {column.HeaderText} - Quantità: {rowCell.Value} - Costo: {AsInt(rowCell.Value) * AsInt(minimumCell.Value)}\n\n";
                    mainDataGridView.Rows.RemoveAt(minimumCell.RowIndex);
                    lastCell.Value = AsInt(lastCell.Value) - AsInt(columnCell.Value);
                    Refresh();
                }
                else if (AsInt(rowCell.Value) == AsInt(columnCell.Value))
                {
                    totalCost = totalCost + AsInt(minimumCell.Value) * AsInt(rowCell.Value);
                    richTextBoxProcess.Text += $"Da {mainDataGridView.Rows[minimumCell.RowIndex].Cells[0].Value} a {column.HeaderText} - Quantità: {columnCell.Value} - Costo: {AsInt(columnCell.Value) * AsInt(minimumCell.Value)}\n\n";
                    mainDataGridView.Rows.RemoveAt(minimumCell.RowIndex);
                    mainDataGridView.Columns.RemoveAt(minimumCell.ColumnIndex);
                    lastCell.Value = AsInt(lastCell.Value) - AsInt(rowCell.Value);
                    Refresh();
                }

                column.DefaultCellStyle.BackColor = default;
                row.DefaultCellStyle.BackColor = default;
                Refresh();

                if (minimumCell == null || rowCell == null || columnCell == null || mainDataGridView == null || richTextBoxProcess == null || lastCell == null)
                {
                    throw new Exception("Eccezione!");
                }
            }

            mainDataGridView.Enabled = true;
            buttonCreateGrid.Enabled = true;
            buttonReload.Enabled = true;
            buttonResume.Enabled = true;
        }

        /// <summary>
        /// Ottiene la <see cref="DataGridViewCell"/> con il valore minore all'interno della <see cref="DataGridView"/>.
        /// </summary>
        private DataGridViewCell MinimumCell()
        {
            var cells = new List<DataGridViewCell>();
            DataGridViewCell minimumCell = default;

            for (var j = 0; j < mainDataGridView.RowCount - 1; j++)
            {
                for (var i = 1; i < mainDataGridView.ColumnCount - 1; i++)
                {
                    cells.Add(mainDataGridView.Rows[j].Cells[i]);
                }
            }

            var _minimumCells = cells.Where(x => AsInt(x.Value) == AsInt(cells.OrderBy(k => AsInt(k.Value)).First().Value)).ToList();
            var columnTotalValue = 0;
            var temp = 0;

            foreach (var cell in _minimumCells)
            {
                temp = AsInt(mainDataGridView.Rows[mainDataGridView.RowCount - 1].Cells[cell.ColumnIndex].Value);

                if (temp > columnTotalValue)
                {
                    columnTotalValue = temp;
                    minimumCell = cell;
                }
            }

            return minimumCell;
        }
        #endregion

        #region MetodoVogel
        private void VogelMethod()
        {
            var _rowDiscards = new List<int>();
            var _columnDiscards = new List<int>();
            var rowIndexMinimum = MinimumCell().OwningRow;
            var columnIndexMinimum = MinimumCell().OwningColumn;

            mainDataGridView.Columns.Add("Discard", "Scarti");
            mainDataGridView.Rows.Add("Scarti");
            mainDataGridView.Columns["Discard"].Width = 80;
            mainDataGridView.Columns["Discard"].DefaultCellStyle.BackColor = Color.Beige;
            mainDataGridView.RowTemplate.Height = 25;
            mainDataGridView.Rows[mainDataGridView.RowCount - 1].DefaultCellStyle.BackColor = Color.Beige;
            mainDataGridView.Rows[mainDataGridView.RowCount - 1].Cells[0].Style.BackColor = Color.White;

            AllignCells(1);

            for (var j = 1; j < mainDataGridView.ColumnCount - 2; j++)
            {
                Discard(typeof(DataGridViewColumn).ToString(), j);
                _columnDiscards.Add(AsInt(mainDataGridView.Rows[mainDataGridView.RowCount - 1].Cells[j].Value));
            }

            for (var j = 0; j < mainDataGridView.RowCount - 2; j++)
            {
                Discard(typeof(DataGridViewRow).ToString(), j);
                _rowDiscards.Add(AsInt(mainDataGridView.Rows[j].Cells[mainDataGridView.ColumnCount - 1].Value));
            }

            var maxDiscardRow = _rowDiscards.Max();
            var maxDiscardColumn = _columnDiscards.Max();

        }

        private int Discard(string band, int index)
        {
            var discard = 0;
            var _values = new List<int>();

            switch (band)
            {
                case "System.Windows.Forms.DataGridViewRow":
                    for (var j = 1; j < mainDataGridView.ColumnCount - 1; j++)
                    {
                        _values.Add(AsInt(mainDataGridView.Rows[index].Cells[j].Value));
                    }
                    _values = _values.OrderBy(x => x).ToList();
                    discard = _values[1] - _values[0];
                    mainDataGridView.Rows[index].Cells[mainDataGridView.ColumnCount - 1].Value = discard;
                    break;
                case "System.Windows.Forms.DataGridViewColumn":
                    for (var j = 0; j < mainDataGridView.RowCount - 1; j++)
                    {
                        _values.Add(AsInt(mainDataGridView.Rows[j].Cells[index].Value));
                    }
                    _values = _values.OrderBy(x => x).ToList();
                    discard = _values[1] - _values[0];
                    mainDataGridView.Rows[mainDataGridView.RowCount - 1].Cells[index].Value = discard;
                    break;
            }
            _values.Clear();

            return discard;
        }
        #endregion

        #region MetodoRussel
        public void RusselMethod()
        {

        }
        #endregion

        #region Utility
        /// <summary>
        /// Controlla che non vengano inseriti valori diversi dal tipo <see cref="Int32"/> nelle <see cref="DataGridViewCell"/> della <see cref="DataGridView"/>, quando questo avviene, viene cancellato l'<see cref="KeyPressEventArgs"/> relativo al tasto premuto.
        /// </summary>
        private static void NumericCheck(object sender, KeyPressEventArgs e)
        {
            DataGridViewTextBoxEditingControl s = sender as DataGridViewTextBoxEditingControl;

            if (s != null && (e.KeyChar == '.' || e.KeyChar == ','))
            {
                e.KeyChar = default;
                e.Handled = s.Text.Contains(e.KeyChar);
            }
            else
            {
                e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
            }
        }

        /// <summary>
        /// Ottiene tutti i <see cref="Control"/> del tipo specificato presenti nella <see cref="Form"/>.
        /// </summary>
        private IEnumerable<Control> AllControls(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();
            return controls.SelectMany(ctrls => AllControls(ctrls, type)).Concat(controls).Where(c => c.GetType() == type);
        }

        /// <summary>
        /// Allinea a destra il contenuto delle <see cref="DataGridViewCell"/> della <see cref="DataGridView"/>.
        /// </summary>
        public void AllignCells(int offset)
        {
            mainDataGridView.Columns.GetLastColumn(DataGridViewElementStates.Displayed, DataGridViewElementStates.None).HeaderCell.Style.Alignment = (DataGridViewContentAlignment)64;

            foreach (DataGridViewRow row in mainDataGridView.Rows)
            {
                row.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
        }

        /// <summary>
        /// Converte una <see cref="string"/> in <see cref="int"/>.
        /// </summary>
        private int AsInt(object value)
        {
            return int.Parse(value.ToString());
        }

        /// <summary>
        /// Ricarica <see cref="DataGridView"/> e <see cref="RichTextBox"/>.
        /// </summary>
        public override void Refresh()
        {
            mainDataGridView.Refresh();
            richTextBoxProcess.Refresh();
        }

        /// <summary>
        /// Disabilita tutti i controlli di tipo <see cref="RadioButton"/> dell'interfaccia.
        /// </summary>
        private void DisableRadioButtons()
        {
            foreach (RadioButton rdb in AllControls(this, typeof(RadioButton)))
            {
                if (rdb.Checked)
                {
                    rdb.Checked = false;
                }
            }
        }
        #endregion
    }
}