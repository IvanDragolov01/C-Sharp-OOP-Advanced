namespace _04.GenericSwapMethodIntegers
{
	public class Box<T>
	{
		public T _item;

		public Box(T item)
		{
			_item = item;
		}

		public override string ToString()
		{
			return $"{_item.GetType().FullName}: {_item}";
		}
	}
}
