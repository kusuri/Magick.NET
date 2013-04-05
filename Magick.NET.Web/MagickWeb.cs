﻿//=================================================================================================
// Copyright 2013 Dirk Lemstra
//
// Licensed under the ImageMagick License (the "License"); you may not use this file except in 
// compliance with the License. You may obtain a copy of the License at
//
//   http://www.imagemagick.org/script/license.php
//
// Unless required by applicable law or agreed to in writing, software distributed under the
// License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
// express or implied. See the License for the specific language governing permissions and
// limitations under the License.
//=================================================================================================

using System;
using System.Linq;
using System.Web.Hosting;

namespace ImageMagick
{
	//==============================================================================================
	public static class MagickWeb
	{
		//===========================================================================================
		public static void Initialize()
		{
			string path = HostingEnvironment.MapPath(@"~\Bin\ImageMagick");
			MagickNET.Initialize(path);
		}
		//===========================================================================================
	}
	//==============================================================================================
}