namespace ExtensionMethods
{
    // Extension methodlar var olan tipe yeni bir method eklemek için kullanılırlar.
    // Bu örnekte string tipine Degistir adında yeni bir method eklendi.
    // Class static olmalıdır.
    public static class AdDegistir
    {
        // Method static olacak , ayrıca extend edilecek method paramatre olarak verilecek ve başına this ifadesi eklenecek.
        public static string Degistir(this string ad){
            ad="Ahmet";
            return ad;
        }
    }
}