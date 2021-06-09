namespace DSED_05.Business
{
    /// <summary>
    /// Factory Base.
    /// </summary>
    public static class Factory
    {
        /// <summary>
        /// Gets a Punter.
        /// </summary>
        /// <param name="id">Punter ID.</param>
        /// <returns>Punter Object.</returns>
        public static Punter GetAPunter(int id)
        {
            switch (id)
            {
                case 0:
                    return new Jack();
                case 1:
                    return new Vaughn();
                case 2:
                    return new Jeremy();
                default:
                    return null;
            }
        }
    }
}
