namespace Roughcut.Community.SharedKernel.ConstsAndEnums
{
    // ReSharper disable once InconsistentNaming
    // using internal Z00 - Z90 incrementing by 10
    // production = Z00
    // staging = Z50
    // development = Z90
    public enum DevZoneType
    {

        Z00_Production = 0, // Production
        Z10_PreProduction = 10, // Pre-Production
        Z20_Staging = 20, // Staging


        //Z30_Testing = 30, // Testing
        //Z40_QA = 40, // QA
        //Z50_UAT = 50, // UAT

        //Z70_Sandbox = 70, // Sandbox
        //Z80_Demo = 80, // Demo
        Z80_LocalIIS = 80, // Development

        Z90_LocalDevelopment = 90 // Local Development

    }
}
