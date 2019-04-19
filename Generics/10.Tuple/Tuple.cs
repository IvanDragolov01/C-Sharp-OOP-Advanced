namespace _10.Tuple
{
	public class Tuple<T,P>
	{
		private T _firstItem;
		private P _secondItem;

		public Tuple(T firstItem, P secondItem)
		{
			_firstItem = firstItem;
			_secondItem = secondItem;
		}

		public override string ToString()
		{
			return $"{_firstItem} -> {_secondItem}";
		}
		
	}
}