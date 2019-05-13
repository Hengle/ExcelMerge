using System.Collections.Generic;

namespace NetDiff
{
    public class DiffOption<T>
    {
        public IEqualityComparer<T> EqualityComparer { get; set; }
        public int Limit { get; set; }

        // �Ż�ģʽ���������һ����֧�����������ױ���
        public bool Optimize = true;
    }
}
