using ClassLibrary;

namespace ExtensionNamespace {
    public static class ProductExtension
    {
        // We can extend the methods in particullar class in static classes 
        public static int GetDiscountPlusFive(this Product product) {
            return product.Discount + 5;
        }
    }
}