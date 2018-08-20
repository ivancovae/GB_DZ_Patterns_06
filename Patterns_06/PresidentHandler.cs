namespace Patterns_06
{
    /// <summary>
    /// Президент фирмы
    /// </summary>
    class PresidentHandler : AbstractHandler
    {
        /// <summary>
        /// Запрос президенту фирмы
        /// </summary>
        /// <param name="price">запрос денег</param>
        /// <returns>результат запроса</returns>
        public override string GetMoney(int price)
        {
            if (price <= 10000)
            {
                return $"President give {price} dollars";
            }
            else
            {
                return base.GetMoney(price);
            }
        }
    }
}
