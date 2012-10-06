//
// mTouch-PDFReader library
// ObjectActivator.cs (Objects activator)
//
//  Author:
//       Alexander Matsibarov (macasun) <amatsibarov@gmail.com>
//
//  Copyright (c) 2012 Alexander Matsibarov
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.
//

using System;
using mTouchPDFReader.Library.Data.Managers;

namespace mTouchPDFReader.Library.Data
{
	public class ObjectsActivator
	{
		private bool _Initialized;		

		#region Logic			
		/// <summary>
		/// Creates objects
		/// </summary>
		public void CreateObjects()
		{
			if (!_Initialized) {
				_Initialized = true;
				OptionsManager.Instance = CreateOptionsManager();
				DocumentNoteManager.Instance = CreateDocumentNoteManager();
				DocumentBookmarkManager.Instance = CreateDocumentBookmarkManager();
			}	
		}
		
		/// <summary>
		/// Returns OptionsManager instance
		/// </summary>
		/// <returns></returns>
		private OptionsManager CreateOptionsManager()
		{
			return new OptionsManager();
		}
		
		/// <summary>
		/// Returns DocumentNoteManager instance
		/// </summary>
		/// <returns></returns>
		protected virtual DocumentNoteManager CreateDocumentNoteManager()
		{
			return new DocumentNoteManager();
		}
		
		/// <summary>
		/// Returns DocumentBookmarkManager instance
		/// </summary>
		/// <returns></returns>
		protected virtual DocumentBookmarkManager CreateDocumentBookmarkManager()
		{
			return new DocumentBookmarkManager();
		}		
		#endregion
	}
}

