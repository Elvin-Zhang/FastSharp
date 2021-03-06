﻿// Copyright 2014 Toni Petrina
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace FastSharpIDE.Common
{
    static class Extensions
    {
        public static void AddRange<T>(this ObservableCollection<T> @this, IEnumerable<T> items)
        {
            if (@this == null)
                throw new NullReferenceException();

            if (items == null)
                return;

            foreach (var item in items)
                @this.Add(item);
        }
    }
}
