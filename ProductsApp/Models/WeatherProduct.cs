using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductsApp.Models
{
    public class WeatherProduct
    {
        public class ProviderField
        {
            public string codeField { get; set; }
            public object nameField { get; set; }
        }

        public class TextWeatherField
        {
            public string weatherProductTypeField { get; set; }
            public string locationCodeField { get; set; }
            public string regionField { get; set; }
            public object otherRegionField { get; set; }
            public string issuanceDateTimeField { get; set; }
            public object validityBeginDateTimeField { get; set; }
            public object validityEndDateTimeField { get; set; }
            public object cancelDateTimeField { get; set; }
            public object blockEndDateTimeField { get; set; }
            public string receptionDateTimeField { get; set; }
            public string weatherMessageField { get; set; }
            public ProviderField providerField { get; set; }
            public object sourceTypeField { get; set; }
            public object sourceIdField { get; set; }
            public object authorizedSourceField { get; set; }
            public string actionFlagField { get; set; }
            public string wMOHeaderField { get; set; }
            public string wMOProductIdField { get; set; }
            public string wMOOriginatingCenterField { get; set; }
            public string wMOReportingDateTimeField { get; set; }
            public object wMORepeaterField { get; set; }
            public string weatherMessageTypeField { get; set; }
            public string weatherMessageSubTypeCodeField { get; set; }
            public object weatherMessageSubTypeField { get; set; }
            public double temperatureCelsiusField { get; set; }
            public bool temperatureCelsiusFieldSpecified { get; set; }
            public double temperatureFahrenheitField { get; set; }
            public bool temperatureFahrenheitFieldSpecified { get; set; }
            public double pressureMillibarsField { get; set; }
            public bool pressureMillibarsFieldSpecified { get; set; }
            public double pressureInchesField { get; set; }
            public bool pressureInchesFieldSpecified { get; set; }
            public int windHeadingField { get; set; }
            public bool windHeadingFieldSpecified { get; set; }
            public bool windHeadingMagneticNorthFlagField { get; set; }
            public bool windHeadingMagneticNorthFlagFieldSpecified { get; set; }
            public int windSpeedRawField { get; set; }
            public bool windSpeedRawFieldSpecified { get; set; }
            public int windGustSpeedRawField { get; set; }
            public bool windGustSpeedRawFieldSpecified { get; set; }
            public string windSpeedRawUnitsField { get; set; }
            public int windSpeedKnotsField { get; set; }
            public bool windSpeedKnotsFieldSpecified { get; set; }
            public int windGustSpeedKnotsField { get; set; }
            public bool windGustSpeedKnotsFieldSpecified { get; set; }
            public bool windVariableFlagField { get; set; }
            public bool windVariableFlagFieldSpecified { get; set; }
            public int windVariableHeadingMinField { get; set; }
            public bool windVariableHeadingMinFieldSpecified { get; set; }
            public int windVariableHeadingMaxField { get; set; }
            public bool windVariableHeadingMaxFieldSpecified { get; set; }
            public object weatherIdentifierField { get; set; }
            public object weatherHazardTypeField { get; set; }
            public object weatherHazardSeverityField { get; set; }
            public object stormNameField { get; set; }
            public object volcanoVAACField { get; set; }
            public object volcanoNameNumberField { get; set; }
            public object volcanoNameField { get; set; }
            public object volcanoNumberField { get; set; }
            public object volcanoAreaField { get; set; }
            public object volcanoAdvisoryNumberField { get; set; }
            public object volcanoAviationColorCodeField { get; set; }
            public int elevationField { get; set; }
            public bool elevationFieldSpecified { get; set; }
            public object elevationUnitsField { get; set; }
            public double latitudeDecimalField { get; set; }
            public bool latitudeDecimalFieldSpecified { get; set; }
            public object latitudeHemisphereField { get; set; }
            public int latitudeDegreesField { get; set; }
            public bool latitudeDegreesFieldSpecified { get; set; }
            public int latitudeMinutesField { get; set; }
            public bool latitudeMinutesFieldSpecified { get; set; }
            public int latitudeSecondsField { get; set; }
            public bool latitudeSecondsFieldSpecified { get; set; }
            public double longitudeDecimalField { get; set; }
            public bool longitudeDecimalFieldSpecified { get; set; }
            public object longitudeHemisphereField { get; set; }
            public int longitudeDegreesField { get; set; }
            public bool longitudeDegreesFieldSpecified { get; set; }
            public int longitudeMinutesField { get; set; }
            public bool longitudeMinutesFieldSpecified { get; set; }
            public int longitudeSecondsField { get; set; }
            public bool longitudeSecondsFieldSpecified { get; set; }
            public object aircraftSizeCategoryField { get; set; }
            public int flightLevelField { get; set; }
            public bool flightLevelFieldSpecified { get; set; }
            public object pirepTurbulenceIntensityField { get; set; }
            public object pirepIcingIntensityField { get; set; }
            public object turbulencePlotTypeField { get; set; }
            public int ceilingAltitudeFeetField { get; set; }
            public bool ceilingAltitudeFeetFieldSpecified { get; set; }
            public object precipitationTypesField { get; set; }
            public object obscurationTypesField { get; set; }
            public bool moistureIndicatorField { get; set; }
            public bool moistureIndicatorFieldSpecified { get; set; }
            public object fICONRunwayStatusInfoField { get; set; }
            public object weatherProductGroupField { get; set; }
            public object weatherProductGroupDisplayTextField { get; set; }
            public object weatherProductTypeDisplayTextField { get; set; }
            public int productLocationBaseField { get; set; }
            public bool productLocationBaseFieldSpecified { get; set; }
            public string guidField { get; set; }
            public object carrierCodeField { get; set; }
            public string insertDateTimeField { get; set; }
            public object insertSourceIDField { get; set; }
            public string insertUserIDField { get; set; }
            public string lastUpdateDateTimeField { get; set; }
            public object lastUpdateSourceIDField { get; set; }
            public object lastUpdateUserIDField { get; set; }
            public string updateLockNumberField { get; set; }
        }

        public class ItemsField
        {
            public List<TextWeatherField> textWeatherField { get; set; }
        }

        public class RootObject
        {
            public List<ItemsField> itemsField { get; set; }
            public object echoTokenField { get; set; }
            public string timeStampField { get; set; }
            public bool timeStampFieldSpecified { get; set; }
            public int targetField { get; set; }
            public double versionField { get; set; }
            public object transactionIdentifierField { get; set; }
            public object sequenceNmbrField { get; set; }
            public int transactionStatusCodeField { get; set; }
            public bool transactionStatusCodeFieldSpecified { get; set; }
            public bool retransmissionIndicatorField { get; set; }
            public bool retransmissionIndicatorFieldSpecified { get; set; }
        }
    }
}