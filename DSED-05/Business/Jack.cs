namespace DSED_05.Business
{
    using System.Drawing;

    /// <summary>
    /// Jack Class.
    /// </summary>
    internal class Jack : Punter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Jack"/> class.
        /// </summary>
        public Jack()
        {
            Name = "Jack";
            Cash = 50;
            Color = Color.Blue;
        }
    }
}
