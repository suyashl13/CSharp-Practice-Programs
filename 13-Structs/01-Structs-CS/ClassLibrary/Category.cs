public struct Category
{
    //Private Fields
    private int _categoryID;
    private String _categoryName;

    // Public Fields
    public int CategoryID {
        set {
            if (value >= 1 && value <= 100)
            {
                _categoryID = value;
            } else _categoryID = -1;
        }
        readonly get => this._categoryID;
    }

    public String CategoryName {get; set;}

    public readonly int GetCategoryNameLength() => this._categoryName.Length;

}