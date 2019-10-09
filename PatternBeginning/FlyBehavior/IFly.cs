using System;
using System.Collections.Generic;
using System.Text;

namespace PatternBeginning
{
    /// <summary>
    /// 飞行类接口，所有新的飞行类都必须实现Fly方法
    /// </summary>
    public interface IFly
    {
        void Fly();
    }
}