namespace Generics
{
    public class GenericArray<T>
    {
        private T[] array;
        public GenericArray(int size)
        {
            array = new T[size];
        }

        public T GetItem(int index)
        {
            return array[index];
        }

        public void SetItem(T value, int index)
        {
            array[index] = value;
        }

    }
}
