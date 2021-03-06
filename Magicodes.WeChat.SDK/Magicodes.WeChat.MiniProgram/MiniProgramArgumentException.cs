﻿// ======================================================================
//  
//          Copyright (C) 2016-2020 湖南心莱信息科技有限公司    
//          All rights reserved
//  
//          filename : ApiArgumentException.cs
//          description :
//  
//          created by 李文强 at  2018/04/10 17:10
//          Blog：http://www.cnblogs.com/codelove/
//          GitHub ： https://github.com/xin-lai
//          Home：http://xin-lai.com
//  
// ======================================================================

using System;

namespace Magicodes.WeChat.MiniProgram
{
    /// <summary>
    ///     接口参数异常
    /// </summary>
    public class MiniProgramArgumentException : ArgumentException
    {
        public MiniProgramArgumentException()
        {
        }

        public MiniProgramArgumentException(string message) : base(message)
        {
        }

        public MiniProgramArgumentException(string message, string paramName) : base(message, paramName)
        {
        }
    }
}