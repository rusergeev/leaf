using System.Collections;
using System.Collections.Generic;

namespace Leetcode.Word_Search_II
{
    public class MatrixAsGraph<T>:IEnumerable<int>
    {
        private readonly int N;
        private readonly int M;
        private readonly T[,] Matrix;

        public MatrixAsGraph( T[,] matrix)
        {
            Matrix = matrix;
            N = Matrix.GetLength(0);
            M = Matrix.GetLength(1);
        }

        public T Value(int v)
        {
            return Matrix[v % N, v/ N];
        }
         public int Count
         {
             get { return this.N*this.M; }
         }

        public IEnumerable<int> Next(int v)
        {
            int i = v% N;
            int j = v/ N;
            if (i > 0) yield return i - 1 + j* N;
            if (j > 0) yield return i + (j - 1)* N;
            if (i < N - 1) yield return i + 1 + j* N;
            if (j < M - 1) yield return i + (j + 1)* N;
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < Count; i++) yield return i;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
