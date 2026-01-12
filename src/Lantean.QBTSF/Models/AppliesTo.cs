using System.ComponentModel;

namespace Lantean.QBTSF.Models
{
    public enum AppliesTo
    {
        [Description("Filename + Extension")]
        FilenameExtension,

        Filename,
        Extension
    }
}