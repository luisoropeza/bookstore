namespace BookStore.Application.Common.Utils
{
    public static class BookUtils
    {
        public static double IncludeDiscount(double discount, double price)
        {
            return discount == 0 ? price : price - (price * discount / 100);
        }
    }
}
