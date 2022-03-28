namespace PostoDeGasolinaLibrary.Core.Errors.Either

{
    public class Either<TL, TR>
    {
        private readonly TL? left;
        private readonly TR? right;
        private readonly bool isLeft;

        public Either(TL left)
        {
            this.left = left;
            isLeft = true;
        }

        public Either(TR right)
        {
            this.right = right;
            isLeft = false;
        }

        public T Match<T>(Func<TL, T> leftFunc, Func<TR, T> rightFunc)
        => isLeft ? leftFunc(left!) : rightFunc(right!);

        public static implicit operator Either<TL, TR>(TL left) => new(left);

        public static implicit operator Either<TL, TR>(TR right) => new(right);

    }
}
