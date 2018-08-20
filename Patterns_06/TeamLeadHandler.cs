namespace Patterns_06
{
    /// <summary>
    /// Руководитель группы разработчиков
    /// </summary>
    class TeamLeadHandler : AbstractHandler
    {
        /// <summary>
        /// Запрос руководителю
        /// </summary>
        /// <param name="price">запрос денег</param>
        /// <returns>результат запроса</returns>
        public override string GetMoney(int price)
        {
            if (price <= 100)
            {
                return $"Teamlead give {price} dollars";
            }
            else
            {
                return base.GetMoney(price);
            }
        }
    }
}
