namespace DSED_05
{
    using System;
    using System.Linq;
    using System.Windows.Forms;
    using DSED_05.Business;
    using DSED_05.Properties;
    using DSED05.Properties;

    /// <summary>
    /// Game Form.
    /// </summary>
    public partial class GameForm : Form
    {
        private readonly Racer[] racers = new Racer[4];
        private readonly Punter[] punters = new Punter[3];
        private Label[] lblPuntersBalance;
        private RadioButton[] btnPunter;
        private int racerWinner;

        /// <summary>
        /// Initializes a new instance of the <see cref="GameForm"/> class.
        /// </summary>
        public GameForm()
        {
            InitializeComponent();
            LoadRacers();
            LoadPunters();
            UpdatePuntersBalanceLabels();
        }

        /// <summary>
        /// GameForm Load.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">Event.</param>
        private void GameForm_Load(object sender, EventArgs e)
        {
            btnPunter = new RadioButton[] { btnJack, btnVaughn, btnJeremy };
        }

        /// <summary>
        /// Load Punters.
        /// </summary>
        private void LoadPunters()
        {
            for (int i = 0; i < 3; i++)
            {
                punters[i] = Factory.GetAPunter(i);
                punters[i].LblWinner = lblWinner;
            }

            lblPuntersBalance = new Label[] { lblJack, lblVaughn, lblJeremy };
        }

        /// <summary>
        /// Loads Racers.
        /// </summary>
        private void LoadRacers()
        {
            racers[0] = new Racer { Length = 0, PB = pbRacer1, Name = "BMW" };
            racers[0].PB.BackgroundImage = Resources.bmw_logo;
            racers[1] = new Racer { Length = 0, PB = pbRacer2, Name = "Mercedes" };
            racers[1].PB.BackgroundImage = Resources.mercedes_logo;
            racers[2] = new Racer { Length = 0, PB = pbRacer3, Name = "Audi" };
            racers[2].PB.BackgroundImage = Resources.audi_logo;
            racers[3] = new Racer { Length = 0, PB = pbRacer4, Name = "Porsche" };
            racers[3].PB.BackgroundImage = Resources.porsche_logo;
            for (int i = 0; i < racers.Length; i++)
            {
                cbxRacers.Items.Add(racers[i].Name);
            }
        }

        /// <summary>
        /// Reset Race.
        /// </summary>
        private void ResetRace()
        {
            // Reseting Racers & Bets.
            lbxEvents.Items.Clear();
            foreach (Racer race in racers)
            {
                race.PB.Left = pbRaceTrack.Left;
            }

            int count = 0;

            foreach (Punter punter in punters)
            {
                punter.Bet = 0;

                // Disabling the Punters from playing when they have run out of cash.
                if (punter.Cash == 0)
                {
                    count += 1;
                    foreach (RadioButton radioButton in btnPunter)
                    {
                        if (radioButton.Text == punter.Name)
                        {
                            radioButton.Enabled = false;
                            lbxEvents.Items.Add($"{punter.Name} is Busted");
                        }
                    }
                }

                // If all of the punters have no cash.
                if (count == punters.Length)
                {
                    MessageBox.Show("Game Over, All punters have no more cash. Restarting Game");
                    LoadPunters();
                    UpdatePuntersBalanceLabels();
                    foreach (RadioButton radioButton in btnPunter)
                    {
                        radioButton.Enabled = true;
                    }
                }
            }
        }

        /// <summary>
        /// Run Race.
        /// </summary>
        private void RunRace()
        {
            // Setting all Radio Buttons to false
            foreach (RadioButton radioButton in btnPunter)
            {
                radioButton.Checked = false;
            }

            bool end = false;

            // Running until end has been set to True.
            while (!end)
            {
                // Calculating the distance of track.
                int distance = pbRaceTrack.Width - pbRacer1.Width;

                // Initializing Random.
                Random rand = new Random();

                // Looping over each racer and setting a random number for them to move forward.
                for (int i = 0; i < racers.Length; i++)
                {
                    // Moving their picture boxes that set amount forward.
                    racers[i].PB.Left += rand.Next(1, 5);

                    // Checking if a racer has reached the end.
                    if (racers[i].PB.Left > distance)
                    {
                        // Setting the index of the winner.
                        racerWinner = i;

                        // Setting the end to true.
                        end = true;

                        // Logging the winning racer
                        lbxEvents.Items.Add($"{racers[i].Name} Wins!");
                    }
                }
            }

            // Finding all of the winning and loosing punters.
            FindWinner();
        }

        private void FindWinner()
        {
            // creating an arary with the index of the punters that have won and lost
            int[] winners = Array.Empty<int>();
            int[] loosers = Array.Empty<int>();

            // Looping over the punters.
            for (int i = 0; i < punters.Length; i++)
            {
                // Checking to see if the punter has won.
                if (punters[i].Racer == racerWinner)
                {
                    punters[i].Cash += punters[i].Bet;
                    Array.Resize(ref winners, winners.Length + 1);
                    winners[winners.Length - 1] = i;
                }
                else
                {
                    punters[i].Cash -= punters[i].Bet;
                    Array.Resize(ref loosers, loosers.Length + 1);
                    loosers[loosers.Length - 1] = i;
                }
            }

            // Creating the winners and loosers text to be output into the Events Box.
            string[] winnersTextArr = WinnersText(winners, loosers);
            foreach (string text in winnersTextArr)
            {
                lbxEvents.Items.Add(text);
            }

            // Updating the punters Balance labels.
            UpdatePuntersBalanceLabels();
        }

        private string[] WinnersText(int[] winners, int[] loosers)
        {
            // Looping over the winners and loosers.
            string[] winnersText = new string[3];
            for (int i = 0; i < winners.Length; i++)
            {
                winnersText[i] = $"{punters[winners[i]].Name} Won {punters[winners[i]].Bet}";
            }

            for (int i = 0; i < loosers.Length; i++)
            {
                winnersText[i + winners.Length] = $"{punters[loosers[i]].Name} Lost {punters[loosers[i]].Bet}";
            }

            return winnersText;
        }

        private void UpdatePuntersBalanceLabels()
        {
            for (int i = 0; i < punters.Length; i++)
            {
                lblPuntersBalance[i].Text = $"${punters[i].Cash}";
            }
        }

        private void PlaceBet()
        {
            var currentPunter = puntersRADBox.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);

            if (currentPunter != null)
            {
                if (betAmount.Value.ToString() != "0")
                {
                    if (cbxRacers.SelectedItem != null)
                    {
                        for (int i = 0; i < punters.Length; i++)
                        {
                            if (punters[i].Name == currentPunter.Text)
                            {
                                if (punters[i].Cash >= float.Parse(betAmount.Value.ToString()))
                                {
                                    if (punters[i].Bet == 0)
                                    {
                                        punters[i].Bet = float.Parse(betAmount.Value.ToString());
                                        for (int x = 0; x < racers.Length; x++)
                                        {
                                            if (racers[x].Name == cbxRacers.SelectedItem.ToString())
                                            {
                                                punters[i].Racer = x;
                                            }
                                        }

                                        lbxEvents.Items.Add($"{punters[i].Name} has placed a bet of {punters[i].Bet} on {racers[punters[i].Racer].Name}");
                                    }
                                    else
                                    {
                                        MessageBox.Show("This punter has already placed their bet");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Sorry the bet is to high");
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please choose a Racer");
                    }
                }
                else
                {
                    MessageBox.Show("Please choose a bet Amount");
                }
            }
            else
            {
                MessageBox.Show("Please select a Punter before placing your bet!");
            }
        }

        private bool CheckBetsPlaced()
        {
            for (int i = 0; i < punters.Length; i++)
            {
                if (punters[i].Bet == 0 && punters[i].Cash != 0)
                {
                    return false;
                }
            }

            return true;
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            if (CheckBetsPlaced())
            {
                RunRace();
            }
            else
            {
                MessageBox.Show("Please make sure all bets are placed");
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            ResetRace();
        }

        private void BtnPlaceBet_Click(object sender, EventArgs e)
        {
            PlaceBet();
        }

        private void PunterRad_Changed(object sender, EventArgs e)
        {
            RadioButton rad = (RadioButton)sender;
            if (rad.Checked == true)
            {
                foreach (var punter in punters)
                {
                    if (punter.Name == rad.Text)
                    {
                        betAmount.Maximum = (decimal)punter.Cash;
                    }
                }
            }
        }
    }
}
