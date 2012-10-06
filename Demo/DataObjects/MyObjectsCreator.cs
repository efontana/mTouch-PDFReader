//
// mTouch-PDFReader library
// MyObjectsCreator.cs (DObjects activator)
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
using mTouchPDFReader.Library.Data;
using mTouchPDFReader.Library.Data.Managers;

namespace mTouchPDFReader.Demo.DataObjects
{
	public class MyObjectsActivator : ObjectsActivator
	{
		#region Logic			
		/// <summary>
		/// Returns DocumentNoteManager instance
		/// </summary>
		/// <returns></returns>
		protected override DocumentNoteManager CreateDocumentNoteManager()
		{
			return new MyDocumentNoteManager();
		}
		
		/// <summary>
		/// Returns DocumentBookmarkManager instance
		/// </summary>
		/// <returns></returns>
		protected override DocumentBookmarkManager CreateDocumentBookmarkManager()
		{
			return new MyDocumentBookmarkManager();
		}		
		#endregion
	}
}

