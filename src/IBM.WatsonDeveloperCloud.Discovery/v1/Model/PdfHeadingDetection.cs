

/**
* Copyright 2017 IBM Corp. All Rights Reserved.
*
* Licensed under the Apache License, Version 2.0 the "License";
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
*      http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*
*/

namespace IBM.WatsonDeveloperCloud.Discovery.v1.Model
{
    using System.Linq;

    public partial class PdfHeadingDetection
    {
        /// <summary>
        /// Initializes a new instance of the PdfHeadingDetection class.
        /// </summary>
        public PdfHeadingDetection() { }

        /// <summary>
        /// Initializes a new instance of the PdfHeadingDetection class.
        /// </summary>
        public PdfHeadingDetection(System.Collections.Generic.IList<FontSetting> fonts = default(System.Collections.Generic.IList<FontSetting>))
        {
            Fonts = fonts;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "fonts")]
        public List<FontSetting> Fonts { get; set; }

    }
}