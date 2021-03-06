// Copyright (c) 2012-2020 fo-dicom contributors.
// Licensed under the Microsoft Public License (MS-PL).

namespace Dicom.Network.Client.States
{
    public interface IInitialisationWithConnectionParameters
    {
        IDicomClientConnection Connection { get; set; }
    }
}
