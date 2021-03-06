﻿//**********************************************************************************
//* Copyright (C) 2007,2016 Hitachi Solutions,Ltd.
//**********************************************************************************

#region Apache License
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License. 
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
#endregion

//**********************************************************************************
//* クラス名        ：PingController
//* クラス日本語名  ：Ping Controller for Html.BeginForm
//*
//* 作成日時        ：－
//* 作成者          ：生技
//* 更新履歴        ：
//*
//*  日時        更新者            内容
//*  ----------  ----------------  -------------------------------------------------
//*  2015/12/28  Sai               Added controller to prevent session timeout.
//*  2016/01/12  Sai               Removed method Ping and modified Index method to return empty string.
//*  2016/01/12  Sai               Modfied XML comments.
//**********************************************************************************

using System.Web.Mvc;

namespace MultiPurposeAuthSite.Controllers
{
    /// <summary>
    /// Ping Controller
    /// </summary>
    public class PingController : Controller
    {
        /// <summary>
        /// 画面の初期表示
        /// GET: /Ping/
        /// </summary>
        /// <returns>空の結果を返す (EmptyResult)</returns>
        [HttpGet]
        public ActionResult Index()
        {
            return new EmptyResult();
        }
    }
}
