namespace DSED_05.Business
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    /// <summary>
    /// Punter Base.
    /// </summary>
    public class Punter
    {
        /// <summary>
        /// Gets or sets punter name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets punter racer.
        /// </summary>
        public int Racer { get; set; }

        /// <summary>
        /// Gets or sets punter cash.
        /// </summary>
        public float Cash { get; set; }

        /// <summary>
        /// Gets or sets punter bet.
        /// </summary>
        public float Bet { get; set; }

        /// <summary>
        /// Gets or sets punter Label.
        /// </summary>
        public Label LblWinner { get; set; }

        /// <summary>
        /// Gets or sets punter color.
        /// </summary>
        public Color Color { get; set; }
    }
}
