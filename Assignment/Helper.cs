using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Helper
    {
        // Gardening Tool Types            
        string[] lineTrimmersLabels = new string[5] {"tiny trimmer", "small trimmer", "medium trimmer", "big trimmer", "huge trimmer"};
        string[] lawnMowersLabels = new string[5] { "tiny mower", "small mower", "medium mower", "big mower", "huge mower" };
        string[] handToolsLabels = new string[5] { "tiny handtool", "small hand tool", "medium hand tool", "big hand tool", "huge hand tool" };
        string[] wheelBarrowsLabels = new string[5] { "tiny wheel barrow", "small wheelbarrow", "medium wheelbarrow", "big wheelbarrow", "huge wheelbarrow" };
        string[] gardenPowerToolsLabels = new string[5] { "tiny powertool", "small powertool", "medium powertool", "big powertool", "huge powertool" };
        // Flooring Tools           
        string[] scrapersLabels = new string[5] { "tiny scraper", "small scraper", "medium scraper", "big scraper", "huge scraper" };
        string[] floorLasersLabels = new string[5] { "tiny floor laser", "small floor laser", "medium floor laser", "big floor laser", "huge floor laser" };
        string[] floorLevellingToolsLabels = new string[5] { "tiny levelling tool", "small levelling tool", "medium levelling tool", "big levelling tool", "huge levelling tool" };
        string[] floorLevellingMaterialsLabels = new string[5] { "tiny levelling material", "small levelling material", "medium levelling material", "big levelling material", "huge levelling material" };
        string[] floorHandToolsLabels = new string[5] {"tiny floor hand tool", "small floor hand tool", "medium floor hand tool", "big floor hand tool", "huge floor hand tool"};
        string[] tilingToolsLabels = new string[5] { "tiny tiling tool", "small tiling tool", "medium tiling tool", "big tiling tool", "huge tiling tool" };

        // Fencing Tools            
        string[] fencingHandToolsLabels = new string[5] { "tiny fencing hand tool", "small fencing hand tool", "medium fencing hand tool", "big fencing hand tool", "huge fencing hand tool" };
        string[] electricFencingLabels = new string[5] { "tiny electric fencing", "small electric fencing", "medium electric fencing", "big electric fencing", "huge electric fencing" };
        string[] steelFencingToolsLabels = new string[5] { "tiny steel fencing tools", "small steel fencing tools", "medium steel fencing tools", "big steel fencing tools", "huge steel fencing tools" };
        string[] powerToolsLabels = new string[5] { "tiny power tools", "small power tools", "medium power tools", "big power tools", "huge power tools" };
        string[] fencingAccessoriesLabels = new string[5] { "tiny fencing accessories", "small fencing accessories", "medium fencing accessories", "big fencing accessories", "huge fencing accessories" };

        // Measuring Tools            
        string[] distanceToolsLabels = new string[5] { "tiny distance tools", "small distance tools", "medium distance tools", "big distance tools", "huge distance tools" };
        string[] laserMeasurerLabels = new string[5] { "tiny laser measurer", "small laser measurer", "medium laser measurer", "big laser measurer", "huge laser measurer" };
        string[] measuringJugsLabels = new string[5] { "tiny measuring jugs", "small measuring jugs", "medium measuring jugs", "big measuring jugs", "huge measuring jugs" };
        string[] temperatureAndHumidityToolsLabels = new string[5] { "tiny temperature/humidity tools", "small temperature/humidity tools", "medium temperature/humidity tools", "big temperature/humidity tools", "huge temperature/humidty tools" };
        string[] levellingToolsLabels = new string[5] { "tiny levelling tools", "small levelling tools", "medium levelling tools", "big levelling tools", "huge levelling tools" };
        string[] markersLabels = new string[5] { "tiny markers", "small markers", "medium markers", "big markers", "huge markers" };

        // Cleaning Tools            
        string[] drainingLabels = new string[5] { "tiny draning", "small draining", "medium draining", "big draining", "huge draining" };
        string[] carCleaningLabels = new string[5] { "tiny car cleaning", "small car cleaning", "medium car cleaning", "big car cleaning", "huge car cleaning" };
        string[] vacuumLabels = new string[5] { "tiny vacuum", "small vacuum", "medium vacuum", "big vacuum", "huge vacuum" };
        string[] pressureCleanersLabels = new string[5] { "tiny pressure cleaners", "small pressure cleaners", "medium pressurer cleaners", "big pressurer cleaners", "huge pressurer cleaners" };
        string[] poolCleaningLabels = new string[5] { "tiny pool cleaning", "small pool cleaning", "medium pool cleaning", "big pool cleaning", "huge pool cleaning" };
        string[] floorCleaningLabels = new string[5] { "tiny floor cleaning", "small floor cleaning", "medium floor cleaning", "big floor cleaning", "huge floor cleaning" };

        // Painting Tools            
        string[] sandingToolsLabels = new string[5] { "tiny sanding tool", "small sanding tool", "medium sanding tool", "big sanding tool", "huge sanding tool" };
        string[] brushesLabels = new string[5] { "tiny brush", "small brush", "medium brush", "big brush", "huge brush" };
        string[] rollersLabels = new string[5] { "tiny roller", "small roller", "medium roller", "big roller", "huge roller" };
        string[] paintRemovalToolsLabels = new string[5] { "tiny paint remover", "small paint remover", "medium paint remover", "big paint remover", "huge paint remover" };
        string[] paintScapersLabels = new string[5] { "tiny paint scraper", "small paint scraper", "medium paint scraper", "big paint scraper", "huge paint scraper" };
        string[] sprayersLabels = new string[5] { "tiny sprayer", "small sprayer", "medium sprayer", "big sprayer", "huge sprayer" };

        // Electronic Tools            
        string[] voltageTesterLabels = new string[5] { "tiny voltage tester", "small voltage tester", "medium voltage tester", "big voltage tester", "huge voltage tester" };
        string[] oscilloscopesLabels = new string[5] { "tiny oscilloscope", "small oscilloscope", "medium oscilloscope", "big oscilloscope", "huge oscilloscope" };
        string[] thermalImagingLabels = new string[5] { "tiny thermal imager", "small thermal imager", "medium thermal imager", "big thermal imager", "huge thermal imager" };
        string[] dataTestToolLabels = new string[5] { "tiny data test tool", "small data test tool", "medium data test tool", "big data test tool", "huge data test tool" };
        string[] insulationTestersLabels = new string[5] { "tiny insulation tester", "small insulation tester", "medium insulation tester", "big insulation tester", "huge insulation tester" };

        // Electricity Tools            
        string[] testEquipmentLabels = new string[5] { "tiny test equipment", "small test equipment", "medium test equipment", "big test equipment", "huge test equipment" };
        string[] safetyEquipmentLabels = new string[5] { "tiny safety equipment", "small safety equipment", "medium safety equipment", "big safety equipment", "huge safety equipment" };
        string[] basicHandToolsLabels = new string[5] { "tiny basic hand tool", "small basic hand tool", "medium basic hand tool", "big basic hand tool", "huge basic hand tool" };
        string[] circuitProtectionLabels = new string[5] { "tiny circuit protection", "small circuit protection", "medium circuit protection", "big circuit protection", "huge circuit protection" };
        string[] cableToolsLabels = new string[5] { "tiny cable tool", "small cable tool", "medium cable tool", "big cable tool", "huge cable tool" };

        // Automotive Tools            
        string[] jacksLabels = new string[5] { "tiny jack", "small jack", "medium jack", "big jack", "huge jack" };
        string[] airCompressorsLabels = new string[5] { "tiny air compressor", "small air compressor", "medium air compressor", "big air compressor", "huge air compressor" };
        string[] batteryChargesLabels = new string[5] { "tiny battery charger", "small battery charger", "medium battery charger", "big battery charger", "huge battery charger" };
        string[] socketToolsLabels = new string[5] { "tiny socket tool", "small socket tool", "medium socket tool", "big socket tool", "huge socket tool" };
        string[] brakingLabels = new string[5] { "tiny brakes", "small brakes", "medium brakes", "big brakes", "huge brakes" };
        string[] drivetrainLabels = new string[5] { "tiny drivetrain", "small drivetrain", "medium drivetrain", "big drivetrain", "huge drivetrain" };

        
        

        
            
        
    }

}
        