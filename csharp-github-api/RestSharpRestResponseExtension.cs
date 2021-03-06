﻿//-----------------------------------------------------------------------
// <copyright file="RestSharpRestResponseExtension.cs" company="TemporalCohesion.co.uk">
//     Copyright [2012] [Stuart Grassie]
//
//     Licensed under the Apache License, Version 2.0 (the "License");
//     you may not use this file except in compliance with the License.
//     You may obtain a copy of the License at
//
//      http://www.apache.org/licenses/LICENSE-2.0
//
//     Unless required by applicable law or agreed to in writing, software
//     distributed under the License is distributed on an "AS IS" BASIS,
//     WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//     See the License for the specific language governing permissions and
//     limitations under the License.
// </copyright>
//----------------------------------------------------------------------

using csharp_github_api.Lib;

namespace csharp_github_api
{
    using RestSharp;

    public static class RestSharpRestResponseExtension
    {
        /// <summary>
        /// An extension method which deserializes the <see cref="IRestResponse.Content"/> into a dynamic object"/>
        /// </summary>
        /// <param name="response"></param>
        /// <returns></returns>
        public static dynamic Dynamic(this IRestResponse response)
        {
            return SimpleJson.DeserializeObject(response.Content);
        }

        public static dynamic Dynamic<T>(this IRestResponse<T> response)
        {
            return SimpleJson.DeserializeObject(response.Content);
        }
    }
}
