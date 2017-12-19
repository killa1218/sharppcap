﻿/*
This file is part of SharpPcap.

SharpPcap is free software: you can redistribute it and/or modify
it under the terms of the GNU Lesser General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

SharpPcap is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU Lesser General Public License for more details.

You should have received a copy of the GNU Lesser General Public License
along with SharpPcap.  If not, see <http://www.gnu.org/licenses/>.
*/
/* 
 * Copyright 2017 Noah Potash <noah.potash@outbreaklabs.com>
 */

using System;

namespace SharpPcap
{
    /// <summary>
    /// The activation of monitor mode used when opening a device
    /// </summary>
    public enum MonitorMode : short
    {
        /// <summary>
        /// Monitor mode.
        /// Allows capturing of 802.11 wireless packets even when not associated
        /// with a network.
        /// </summary>
        Active = 1,

        /// <summary>
        /// Not monitor mode
        /// </summary>
        Inactive = 0
    }
}