namespace Patterns_06
{
    /// <summary>
    /// Директор фирмы
    /// </summary>
    class DirectorHandler : AbstractHandler
    {
        /// <summary>
        /// Запрос директору фирмы
        /// </summary>
        /// <param name="price">запрос денег</param>
        /// <returns>результат запроса</returns>
        public override string GetMoney(int price)
        {
            if (price <= 1000)
            {
                return $"Director give {price} dollars";
            }
            else
            {
                return base.GetMoney(price);
            }
        }
    }
}
