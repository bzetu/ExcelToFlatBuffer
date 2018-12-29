using FlatBuffers;
namespace GameFramework.DataTable
{
    public interface ITable
    {
        bool TryGetElement(int key, out IFlatbufferObject element);
        void InitTableKey();
    }
}