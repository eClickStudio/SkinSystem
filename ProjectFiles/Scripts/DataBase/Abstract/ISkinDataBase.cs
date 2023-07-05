public interface ISkinDataBase<SkinType>
{
    SkinType this[int index] { get; }

    public int Count { get; }
}
