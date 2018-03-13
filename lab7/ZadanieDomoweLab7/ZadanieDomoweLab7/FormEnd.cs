using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace ZadanieDomoweLab7
{
    public partial class FormEnd : Form
    {
        DataClassesScoresDataContext context = new DataClassesScoresDataContext();

        bool connection;  //potrzebne do sprawdzenia czy jest internet

        public FormEnd(int points)
        {
            InitializeComponent();

            textBoxScore.Text = points.ToString();
            connection = IsThereInternetConnection();
            ShowScoresTable();
        }

        /// <summary>
        /// Przycisk zapisujący dane z textboxów do bazy danych
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSaveScore_Click(object sender, EventArgs e)
        {
            if(connection == true) //sprawdzamy połączenie z internetem
            {
                RafalStrzechowski_Score score = new RafalStrzechowski_Score
                {
                    Name = textBoxName.Text,
                    Surname = textBoxSurname.Text,
                    Nickname = textBoxNickname.Text,
                    Score = Int32.Parse(textBoxScore.Text)
                };

                context.RafalStrzechowski_Scores.InsertOnSubmit(score);
                context.SubmitChanges();

                ShowScoresTable();
            }
            
            //Nie chcemy, aby ktoś dodawał wyniki wielokrotnie, więc przełączamy textBoxy w ReadOnly i uniemożliwiamy wciśnięcie przycisku
            textBoxName.ReadOnly = true;
            textBoxSurname.ReadOnly = true;
            textBoxNickname.ReadOnly = true;
            buttonSaveScore.Enabled = false;
        }

        /// <summary>
        /// Funkcja pozwala wczytać dane z bazy danych do dataGridView
        /// </summary>
        private void ShowScoresTable()
        {
            if (connection == true) //sprawdzamy połączenie z internetem
            {
                var score = from S in context.RafalStrzechowski_Scores
                            select new
                            {
                                S.Score,
                                S.Name,
                                S.Surname,
                                S.Nickname
                            };
                dataGridViewRanking.DataSource = score;

                //Chcemy mieć wyniki sortowane od najlepszych w dół
                dataGridViewRanking.Sort(dataGridViewRanking.Columns[0], ListSortDirection.Descending);
            }
                
        }

        /// <summary>
        /// Funkcja próbuje połączyć się ze stroną internetowa i na tej podstawie ustala czy jest on dostepny
        /// </summary>
        /// <returns></returns>
        private bool IsThereInternetConnection()
        {
            WebClient client = new WebClient();
            try
            {
                using (client)
                {
                    using (client.OpenRead("http://clients3.google.com/generate_204"))
                    {
                        return true;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

    }
}
