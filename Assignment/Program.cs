using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Program
    {        

        static void Main(string[] args)
        {
            // Instance Variables ---------------- //
            MemberCollection memberCollection = new MemberCollection(); 

            // Gardening Tool Types            
            ToolCollection lineTrimmers = new ToolCollection();
            ToolCollection lawnMowers = new ToolCollection();
            ToolCollection handTools = new ToolCollection();
            ToolCollection wheelBarrows = new ToolCollection();
            ToolCollection gardenPowerTools = new ToolCollection();
            ToolCollection[] gardeningTools = new ToolCollection[5] { lineTrimmers, lawnMowers, handTools, wheelBarrows, gardenPowerTools };
            // Flooring Tools           
            ToolCollection scrapers = new ToolCollection();
            ToolCollection floorLasers = new ToolCollection();
            ToolCollection floorLevellingTools = new ToolCollection();
            ToolCollection floorLevellingMaterials = new ToolCollection();
            ToolCollection floorHandTools = new ToolCollection();
            ToolCollection tilingTools = new ToolCollection();
            ToolCollection[] flooringTools = new ToolCollection[6] { scrapers, floorLasers, floorLevellingTools, floorLevellingMaterials, floorHandTools, tilingTools };
            // Fencing Tools            
            ToolCollection fencingHandTools = new ToolCollection();
            ToolCollection electricFencing = new ToolCollection();
            ToolCollection steelFencingTools = new ToolCollection();
            ToolCollection powerTools = new ToolCollection();
            ToolCollection fencingAccessories = new ToolCollection();
            ToolCollection[] fencingTools = new ToolCollection[5] { fencingHandTools, electricFencing, steelFencingTools, gardenPowerTools, fencingAccessories };
            // Measuring Tools            
            ToolCollection distanceTools = new ToolCollection();
            ToolCollection laserMeasurer = new ToolCollection();
            ToolCollection measuringJugs = new ToolCollection();
            ToolCollection temperatureAndHumidityTools = new ToolCollection();
            ToolCollection levellingTools = new ToolCollection();
            ToolCollection markers = new ToolCollection();
            ToolCollection[] measuringTools = new ToolCollection[6] { distanceTools, laserMeasurer, measuringJugs, temperatureAndHumidityTools, levellingTools, markers };
            // Cleaning Tools            
            ToolCollection draining = new ToolCollection();
            ToolCollection carCleaning = new ToolCollection();
            ToolCollection vacuum = new ToolCollection();
            ToolCollection pressureCleaners = new ToolCollection();
            ToolCollection poolCleaning = new ToolCollection();
            ToolCollection floorCleaning = new ToolCollection();
            ToolCollection[] cleaningTools = new ToolCollection[6] { draining, carCleaning, vacuum, pressureCleaners, poolCleaning, floorCleaning };
            // Painting Tools            
            ToolCollection sandingTools = new ToolCollection();
            ToolCollection brushes = new ToolCollection();
            ToolCollection rollers = new ToolCollection();
            ToolCollection paintRemovalTools = new ToolCollection();
            ToolCollection paintScapers = new ToolCollection();
            ToolCollection sprayers = new ToolCollection();
            ToolCollection[] paintingTools = new ToolCollection[6] { sandingTools, brushes, rollers, paintRemovalTools, paintScapers, sprayers };
            // Electronic Tools            
            ToolCollection voltageTester = new ToolCollection();
            ToolCollection oscilloscopes = new ToolCollection();
            ToolCollection thermalImaging = new ToolCollection();
            ToolCollection dataTestTool = new ToolCollection();
            ToolCollection insulationTesters = new ToolCollection();
            ToolCollection[] electronicTools = new ToolCollection[5] { voltageTester, oscilloscopes, thermalImaging, dataTestTool, insulationTesters };
            // Electricity Tools            
            ToolCollection testEquipment = new ToolCollection();
            ToolCollection safetyEquipment = new ToolCollection();
            ToolCollection basicHandTools = new ToolCollection();
            ToolCollection circuitProtection = new ToolCollection();
            ToolCollection cableTools = new ToolCollection();
            ToolCollection[] electrictyTools = new ToolCollection[5] { testEquipment, safetyEquipment, basicHandTools, circuitProtection, cableTools };
            // Automotive Tools            
            ToolCollection jacks = new ToolCollection();
            ToolCollection airCompressors = new ToolCollection();
            ToolCollection batteryCharges = new ToolCollection();
            ToolCollection socketTools = new ToolCollection();
            ToolCollection braking = new ToolCollection();
            ToolCollection drivetrain = new ToolCollection();
            ToolCollection[] automotiveTools = new ToolCollection[6] { jacks, airCompressors, batteryCharges, socketTools, braking, drivetrain };

            // All Tool Categories
            ToolCollection[][] toolCategories = new ToolCollection[9][] { 
                gardeningTools,
                flooringTools,
                fencingTools,
                measuringTools,
                cleaningTools,
                paintingTools,
                electronicTools,
                electrictyTools,
                automotiveTools
            };

            // Parallel String Arrays
            string[] categoryLabels = new string[9]
            {
                "Gardening Tools",
                "Flooring Tools",
                "Fencing Tools",
                "Measuring Tools",
                "Cleaning Tools",
                "Painting Tools",
                "Electronic Tools",
                "Electricity Tools",
                "Automotive Tools"
            };

            string[] gardeningLabels = { "Line Trimmers", "Lawn Mowers", "Hand Tools", "Wheelbarrows", "Garden Power Tools" };
            string[] flooringLabels = { "Scrapers", "Floor Lasers", "Floor Levelling Tools", "Floor Levelling Materials", "Floor Hand Tools", "Tiling Tools" };
            string[] fencingLabels = { "Hand Tools", "Electric Fencing", "Steel Fencing Tools", "Power Tools", "Fencing Accessories" };
            string[] measuringLabels = { "Distance Tools", "Laser Measurer", "Measuring Jugs", "Temperature & Humidity Tools", "Levelling Tools", "Markers" };
            string[] cleaningLabels = { "Draining", "Car Cleaning", "Vacuum", "Pressure Cleaners", "Pool Cleaning", "Floor Cleaning" };
            string[] paintingLabels = { "Sanding Tools", "Brushes", "Rollers", "Paint Removal Tools", "Paint Scrapers", "Sprayers" };
            string[] electronicLabels = { "Voltage Tester", "Oscilloscopes", "Thermal Imaging", "Data Test Tools", "Insulation Testers" };
            string[] electricityLabels = { "Test Equipment", "Safety Equipment", "Basic Hand Tools", "Circuit Protection", "Cable Tools" };
            string[] automotiveLabels = { "Jacks", "Air Compressors", "Battery Chargers", "Socket Tools", "Braking", "Drivetrain" };

            string[][] categoryLabelsJagged = new string[9][]
            {
                gardeningLabels,
                flooringLabels,
                fencingLabels,
                measuringLabels,
                cleaningLabels,
                paintingLabels,
                electronicLabels,
                electricityLabels,
                automotiveLabels
            };

            // Gardening Tool Types            
            string[] lineTrimmersLabels = new string[5] { "tiny trimmer", "small trimmer", "medium trimmer", "big trimmer", "huge trimmer" };
            string[] lawnMowersLabels = new string[5] { "tiny mower", "small mower", "medium mower", "big mower", "huge mower" };
            string[] handToolsLabels = new string[5] { "tiny handtool", "small hand tool", "medium hand tool", "big hand tool", "huge hand tool" };
            string[] wheelBarrowsLabels = new string[5] { "tiny wheel barrow", "small wheelbarrow", "medium wheelbarrow", "big wheelbarrow", "huge wheelbarrow" };
            string[] gardenPowerToolsLabels = new string[5] { "tiny powertool", "small powertool", "medium powertool", "big powertool", "huge powertool" };
            // Flooring Tools           
            string[] scrapersLabels = new string[5] { "tiny scraper", "small scraper", "medium scraper", "big scraper", "huge scraper" };
            string[] floorLasersLabels = new string[5] { "tiny floor laser", "small floor laser", "medium floor laser", "big floor laser", "huge floor laser" };
            string[] floorLevellingToolsLabels = new string[5] { "tiny levelling tool", "small levelling tool", "medium levelling tool", "big levelling tool", "huge levelling tool" };
            string[] floorLevellingMaterialsLabels = new string[5] { "tiny levelling material", "small levelling material", "medium levelling material", "big levelling material", "huge levelling material" };
            string[] floorHandToolsLabels = new string[5] { "tiny floor hand tool", "small floor hand tool", "medium floor hand tool", "big floor hand tool", "huge floor hand tool" };
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
            
            void LabelFiller(ToolCollection toolCollection, string[] toolLabelArray)
            {
                MemberCollection tempCollection = new MemberCollection();
                ToolLibrarySystem tempLibrary = new ToolLibrarySystem(toolCollection, tempCollection);
                for (int i = 0; i < 5; i++)
                {
                    Tool newTool = new Tool(toolLabelArray[i]);
                    tempLibrary.add(newTool);
                    newTool.Quantity++;
                }
            }

            // Populate Garden Tools
            LabelFiller(lineTrimmers, lineTrimmersLabels);
            LabelFiller(lawnMowers, lawnMowersLabels);
            LabelFiller(handTools, handToolsLabels);
            LabelFiller(wheelBarrows, wheelBarrowsLabels);
            LabelFiller(gardenPowerTools, gardenPowerToolsLabels);
            // Populate Flooring Tools
            LabelFiller(scrapers, scrapersLabels);
            LabelFiller(floorLasers, floorLasersLabels);
            LabelFiller(floorLevellingTools, floorLevellingToolsLabels);
            LabelFiller(floorHandTools, floorHandToolsLabels);
            LabelFiller(tilingTools, tilingToolsLabels);
            // Populate Fencing Tools
            LabelFiller(fencingHandTools, fencingHandToolsLabels);
            LabelFiller(electricFencing, electricFencingLabels);
            LabelFiller(steelFencingTools, steelFencingToolsLabels);
            LabelFiller(powerTools, powerToolsLabels);
            LabelFiller(fencingAccessories, fencingAccessoriesLabels);
            // Populate Measuring Tools
            LabelFiller(distanceTools, distanceToolsLabels);
            LabelFiller(laserMeasurer, laserMeasurerLabels);
            LabelFiller(measuringJugs, measuringJugsLabels);
            LabelFiller(temperatureAndHumidityTools, temperatureAndHumidityToolsLabels);
            LabelFiller(levellingTools, levellingToolsLabels);
            LabelFiller(markers, markersLabels);
            // Populate Cleaning Tools
            LabelFiller(draining, drainingLabels);
            LabelFiller(carCleaning, carCleaningLabels);
            LabelFiller(vacuum, vacuumLabels);
            LabelFiller(pressureCleaners, pressureCleanersLabels);
            LabelFiller(poolCleaning, poolCleaningLabels);
            LabelFiller(floorCleaning, floorCleaningLabels);
            // Populate Painting Tools
            LabelFiller(sandingTools, sandingToolsLabels);
            LabelFiller(brushes, brushesLabels);
            LabelFiller(rollers, rollersLabels);
            LabelFiller(paintRemovalTools, paintRemovalToolsLabels);
            LabelFiller(paintScapers, paintScapersLabels);
            LabelFiller(sprayers, sprayersLabels);
            // Populate Electronic Tools
            LabelFiller(voltageTester, voltageTesterLabels);
            LabelFiller(oscilloscopes, oscilloscopesLabels);
            LabelFiller(thermalImaging, thermalImagingLabels);
            LabelFiller(dataTestTool, dataTestToolLabels);
            LabelFiller(insulationTesters, insulationTestersLabels);
            // Populate Electricity Tools
            LabelFiller(testEquipment, testEquipmentLabels);
            LabelFiller(safetyEquipment, safetyEquipmentLabels);
            LabelFiller(basicHandTools, basicHandToolsLabels);
            LabelFiller(circuitProtection, circuitProtectionLabels);
            LabelFiller(cableTools, cableToolsLabels);
            // Populate Automotive Tools
            LabelFiller(jacks, jacksLabels);
            LabelFiller(airCompressors, airCompressorsLabels);
            LabelFiller(batteryCharges, batteryChargesLabels);
            LabelFiller(socketTools, socketToolsLabels);
            LabelFiller(braking, brakingLabels);
            LabelFiller(drivetrain, drivetrainLabels);



            // Hard Coding
            Member hardCodedMember = new Member("pat", "pat", "0400000000", "1234");
            memberCollection.add(hardCodedMember);
            

            for (int i = 0; i < 5; i++)
            {
                if (lineTrimmers.toArray()[i] != null)
                {
                    lineTrimmers.toArray()[i].NoBorrowings = i;
                }
            }

            Member persistentMember;



            // Method to print the main menu and take inputs from the user
            void MainMenu()
            {                
                bool staffUsernameIncorrect = false;
                bool staffPasswordIncorrect = false;
                
                bool mainMenustate = true;
                while (mainMenustate)
                {                   

                    if ((staffUsernameIncorrect == true) || (staffPasswordIncorrect == true))
                    {
                        Console.WriteLine("Username or password incorrect...");
                    }
                    staffUsernameIncorrect = false;
                    staffPasswordIncorrect = false;                   


                    Console.WriteLine("Welcome to the Tool Library");
                    Console.WriteLine("===========Main Menu===========");
                    Console.WriteLine("1. Staff Login");
                    Console.WriteLine("2. Member Login");
                    Console.WriteLine("0. Exit");
                    Console.WriteLine("===============================");
                    Console.WriteLine("");
                    Console.WriteLine("Please make a selection (1-2, or 0 to exit)");

                    


                    // Read users input and convert the string into an integer
                    string userInput = Console.ReadLine();

                    // Check user input for key press one (1)
                    if (userInput == "1")
                    {
                        Console.Clear();
                        Console.WriteLine("Please enter staff username...");
                        string staffUsername = Console.ReadLine();
                        if (staffUsername != "staff") { staffUsernameIncorrect = true; }
                        Console.Clear();
                        Console.WriteLine("Please enter staff password...");
                        string staffPassword = Console.ReadLine();
                        if (staffPassword != "today123") { staffPasswordIncorrect = true; }
                        Console.Clear();

                        if ((staffUsername == "staff") && (staffPassword == "today123"))
                        {
                            StaffMenu();
                        }
                        else
                        {
                            Console.Clear();
                            mainMenustate = true;
                        }


                    }

                    if (userInput == "2")
                    {
                        Console.Clear();
                        Console.WriteLine("=== Member Login ===");
                        Console.WriteLine("Please enter first name");
                        string memberFirst = Console.ReadLine();
                        Console.WriteLine("Please enter last name");
                        string memberLast = Console.ReadLine();
                        Console.WriteLine("Please enter PIN");
                        string memberPin = Console.ReadLine();

                        Member tempMember = new Member(memberFirst, memberLast, "?", memberPin);                        
                        Member[] tempM = memberCollection.toArray();
                        if(Array.Exists(tempM, x => (x.LastName, x.FirstName, x.PIN) == (tempMember.LastName, tempMember.FirstName, tempMember.PIN)))
                        {
                            persistentMember = (tempM.First(x => (x.LastName, x.FirstName, x.PIN) == (tempMember.LastName, tempMember.FirstName, tempMember.PIN)));
                            MemberMenu();
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Member does not exist...enter 0 to return to menu");
                            string failureInput = Console.ReadLine();
                            if (failureInput == "0")
                            {
                                Console.Clear();
                                mainMenustate = true;
                            }
                        }

                    }
                    
                }
                    
                
            }

            void StaffMenu()
            {
                bool staffMenuState = true;
                while (staffMenuState)
                {

                    Console.Clear();
                    Console.WriteLine("Welcome to the Tool Library");
                    Console.WriteLine("================Staff Menu================");
                    Console.WriteLine("1. Add a new tool");
                    Console.WriteLine("2. Add new pieces of an existing tool");
                    Console.WriteLine("3. Remove some pieces of a tool");
                    Console.WriteLine("4. Register a new member");
                    Console.WriteLine("5. Remove a member");
                    Console.WriteLine("6. Find the contact number of a member");
                    Console.WriteLine("0. Return to the main menu");
                    Console.WriteLine("==========================================");

                    // Read users input and convert the string into an integer
                    string userInput = Console.ReadLine();

                    if (userInput == "0") { Console.Clear(); staffMenuState = false; }
                    else if( userInput == "1")
                    { 
                        Console.Clear();
                        Console.WriteLine("Tool Library System - Add New Tool To Library");
                        Console.WriteLine("============================================="); 
                        Console.WriteLine("Enter the name of the new Tool (0 to exit): ");
                        string newToolName = Console.ReadLine();
                        Console.WriteLine("Enter the quantity you wish to add: ");
                        string newToolQuantity = Console.ReadLine();
                        int newToolQuantityInt = Int32.Parse(newToolQuantity);
                        Console.WriteLine("");
                        Console.WriteLine("Select category tool belongs to");
                        for (int i = 0; i < categoryLabels.Length; i++)
                        {
                            Console.WriteLine($"{i +1}: " + $"{categoryLabels[i]}");
                        }                        
                        Console.WriteLine("Select option from menu (0 to exit): ");
                        string toolCategoryInput = Console.ReadLine();
                        int toolCategoryIndex = (Int32.Parse(toolCategoryInput) - 1); 
                        if (toolCategoryInput == "1")
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Select the Tool Type");
                            Console.WriteLine("====================");
                            for (int i = 0; i < gardeningLabels.Length; i++)
                            {
                                Console.WriteLine($"{i + 1}: " + $"{gardeningLabels[i]}");
                            }                            
                            Console.WriteLine("Select option from menu (0 to exit): ");
                            string toolTypeInput = Console.ReadLine();
                            int toolTypeIndex = (Int32.Parse(toolTypeInput) - 1);
                            
                            for (int i = 0; i < toolCategories.Length; i++)
                            {
                                if (toolCategoryIndex == i)
                                {
                                    for (int j = 0; j < toolCategories[i].Length; j++)
                                    {
                                        if (toolTypeIndex == j)
                                        {
                                            ToolLibrarySystem tempLibrary = new ToolLibrarySystem(toolCategories[i][j], memberCollection);
                                            Tool newTool = new Tool(newToolName);
                                            tempLibrary.add(newTool);
                                            newTool.Quantity += newToolQuantityInt;
                                            Console.WriteLine("");
                                            Console.WriteLine($"{newTool.Name} has been added to the library, press any key to return to staff menu");
                                            Console.ReadKey();
                                            
                                        }
                                    }
                                }
                                
                            }

                            for (int i = 0; i < toolCategories.Length; i++)
                            {
                                if (toolCategoryIndex == i)
                                {
                                    toolCategoryIndex = i;
                                }
                            }

                        }
                        else if (toolCategoryInput == "2")
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Select the Tool Type");
                            Console.WriteLine("====================");
                            for (int i = 0; i < flooringLabels.Length; i++)
                            {
                                Console.WriteLine($"{i + 1}: " + $"{flooringLabels[i]}");
                            }
                            Console.WriteLine("Select option from menu (0 to exit): ");
                            string toolTypeInput = Console.ReadLine();
                            int toolTypeIndex = (Int32.Parse(toolTypeInput) - 1);

                            for (int i = 0; i < toolCategories.Length; i++)
                            {
                                if (toolCategoryIndex == i)
                                {
                                    for (int j = 0; j < toolCategories[i].Length; j++)
                                    {
                                        if (toolTypeIndex == j)
                                        {
                                            ToolLibrarySystem tempLibrary = new ToolLibrarySystem(toolCategories[i][j], memberCollection);
                                            Tool newTool = new Tool(newToolName);
                                            tempLibrary.add(newTool);
                                            newTool.Quantity += newToolQuantityInt;
                                            Console.WriteLine("");
                                            Console.WriteLine($"{newTool.Name} has been added to the library, press any key to return to staff menu");
                                            Console.ReadKey();
                                        }
                                    }
                                }

                            }
                        }
                        else if (toolCategoryInput == "3")
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Select the Tool Type");
                            Console.WriteLine("====================");
                            for (int i = 0; i < fencingLabels.Length; i++)
                            {
                                Console.WriteLine($"{i + 1}: " + $"{fencingLabels[i]}");
                            }
                            Console.WriteLine("Select option from menu (0 to exit): ");
                            string toolTypeInput = Console.ReadLine();
                            int toolTypeIndex = (Int32.Parse(toolTypeInput) - 1);

                            for (int i = 0; i < toolCategories.Length; i++)
                            {
                                if (toolCategoryIndex == i)
                                {
                                    for (int j = 0; j < toolCategories[i].Length; j++)
                                    {
                                        if (toolTypeIndex == j)
                                        {
                                            ToolLibrarySystem tempLibrary = new ToolLibrarySystem(toolCategories[i][j], memberCollection);
                                            Tool newTool = new Tool(newToolName);
                                            tempLibrary.add(newTool);
                                            newTool.Quantity += newToolQuantityInt;
                                            Console.WriteLine("");
                                            Console.WriteLine($"{newTool.Name} has been added to the library, press any key to return to staff menu");
                                            Console.ReadKey();
                                        }
                                    }
                                }

                            }
                        }
                        else if (toolCategoryInput == "4")
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Select the Tool Type");
                            Console.WriteLine("====================");
                            for (int i = 0; i < measuringLabels.Length; i++)
                            {
                                Console.WriteLine($"{i + 1}: " + $"{measuringLabels[i]}");
                            }
                            Console.WriteLine("Select option from menu (0 to exit): ");
                            string toolTypeInput = Console.ReadLine();
                            int toolTypeIndex = (Int32.Parse(toolTypeInput) - 1);

                            for (int i = 0; i < toolCategories.Length; i++)
                            {
                                if (toolCategoryIndex == i)
                                {
                                    for (int j = 0; j < toolCategories[i].Length; j++)
                                    {
                                        if (toolTypeIndex == j)
                                        {
                                            ToolLibrarySystem tempLibrary = new ToolLibrarySystem(toolCategories[i][j], memberCollection);
                                            Tool newTool = new Tool(newToolName);
                                            tempLibrary.add(newTool);
                                            newTool.Quantity += newToolQuantityInt;
                                            Console.WriteLine("");
                                            Console.WriteLine($"{newTool.Name} has been added to the library, press any key to return to staff menu");
                                            Console.ReadKey();
                                        }
                                    }
                                }

                            }
                        }
                        else if (toolCategoryInput == "5")
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Select the Tool Type");
                            Console.WriteLine("====================");
                            for (int i = 0; i < cleaningLabels.Length; i++)
                            {
                                Console.WriteLine($"{i + 1}: " + $"{cleaningLabels[i]}");
                            }
                            Console.WriteLine("Select option from menu (0 to exit): ");
                            string toolTypeInput = Console.ReadLine();
                            int toolTypeIndex = (Int32.Parse(toolTypeInput) - 1);

                            for (int i = 0; i < toolCategories.Length; i++)
                            {
                                if (toolCategoryIndex == i)
                                {
                                    for (int j = 0; j < toolCategories[i].Length; j++)
                                    {
                                        if (toolTypeIndex == j)
                                        {
                                            ToolLibrarySystem tempLibrary = new ToolLibrarySystem(toolCategories[i][j], memberCollection);
                                            Tool newTool = new Tool(newToolName);
                                            tempLibrary.add(newTool);
                                            newTool.Quantity += newToolQuantityInt;
                                            Console.WriteLine("");
                                            Console.WriteLine($"{newTool.Name} has been added to the library, press any key to return to staff menu");
                                            Console.ReadKey();
                                        }
                                    }
                                }

                            }
                        }
                        else if (toolCategoryInput == "6")
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Select the Tool Type");
                            Console.WriteLine("====================");
                            for (int i = 0; i < paintingLabels.Length; i++)
                            {
                                Console.WriteLine($"{i + 1}: " + $"{paintingLabels[i]}");
                            }
                            Console.WriteLine("Select option from menu (0 to exit): ");
                            string toolTypeInput = Console.ReadLine();
                            int toolTypeIndex = (Int32.Parse(toolTypeInput) - 1);

                            for (int i = 0; i < toolCategories.Length; i++)
                            {
                                if (toolCategoryIndex == i)
                                {
                                    for (int j = 0; j < toolCategories[i].Length; j++)
                                    {
                                        if (toolTypeIndex == j)
                                        {
                                            ToolLibrarySystem tempLibrary = new ToolLibrarySystem(toolCategories[i][j], memberCollection);
                                            Tool newTool = new Tool(newToolName);
                                            tempLibrary.add(newTool);
                                            newTool.Quantity += newToolQuantityInt;
                                            Console.WriteLine("");
                                            Console.WriteLine($"{newTool.Name} has been added to the library, press any key to return to staff menu");
                                            Console.ReadKey();
                                        }
                                    }
                                }

                            }
                        }
                        else if (toolCategoryInput == "7")
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Select the Tool Type");
                            Console.WriteLine("====================");
                            for (int i = 0; i < electronicLabels.Length; i++)
                            {
                                Console.WriteLine($"{i + 1}: " + $"{electronicLabels[i]}");
                            }
                            Console.WriteLine("Select option from menu (0 to exit): ");
                            string toolTypeInput = Console.ReadLine();
                            int toolTypeIndex = (Int32.Parse(toolTypeInput) - 1);

                            for (int i = 0; i < toolCategories.Length; i++)
                            {
                                if (toolCategoryIndex == i)
                                {
                                    for (int j = 0; j < toolCategories[i].Length; j++)
                                    {
                                        if (toolTypeIndex == j)
                                        {
                                            ToolLibrarySystem tempLibrary = new ToolLibrarySystem(toolCategories[i][j], memberCollection);
                                            Tool newTool = new Tool(newToolName);
                                            tempLibrary.add(newTool);
                                            newTool.Quantity += newToolQuantityInt;
                                            Console.WriteLine("");
                                            Console.WriteLine($"{newTool.Name} has been added to the library, press any key to return to staff menu");
                                            Console.ReadKey();
                                        }
                                    }
                                }

                            }
                        }
                        else if (toolCategoryInput == "8")
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Select the Tool Type");
                            Console.WriteLine("====================");
                            for (int i = 0; i < electricityLabels.Length; i++)
                            {
                                Console.WriteLine($"{i + 1}: " + $"{electricityLabels[i]}");
                            }
                            Console.WriteLine("Select option from menu (0 to exit): ");
                            string toolTypeInput = Console.ReadLine();
                            int toolTypeIndex = (Int32.Parse(toolTypeInput) - 1);

                            for (int i = 0; i < toolCategories.Length; i++)
                            {
                                if (toolCategoryIndex == i)
                                {
                                    for (int j = 0; j < toolCategories[i].Length; j++)
                                    {
                                        if (toolTypeIndex == j)
                                        {
                                            ToolLibrarySystem tempLibrary = new ToolLibrarySystem(toolCategories[i][j], memberCollection);
                                            Tool newTool = new Tool(newToolName);
                                            tempLibrary.add(newTool);
                                            newTool.Quantity += newToolQuantityInt;
                                            Console.WriteLine("");
                                            Console.WriteLine($"{newTool.Name} has been added to the library, press any key to return to staff menu");
                                            Console.ReadKey();
                                        }
                                    }
                                }

                            }
                        }
                        else if (toolCategoryInput == "9")
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Select the Tool Type");
                            Console.WriteLine("====================");
                            for (int i = 0; i < automotiveLabels.Length; i++)
                            {
                                Console.WriteLine($"{i + 1}: " + $"{automotiveLabels[i]}");
                            }
                            Console.WriteLine("Select option from menu (0 to exit): ");
                            string toolTypeInput = Console.ReadLine();
                            int toolTypeIndex = (Int32.Parse(toolTypeInput) - 1);

                            for (int i = 0; i < toolCategories.Length; i++)
                            {
                                if (toolCategoryIndex == i)
                                {
                                    for (int j = 0; j < toolCategories[i].Length; j++)
                                    {
                                        if (toolTypeIndex == j)
                                        {
                                            ToolLibrarySystem tempLibrary = new ToolLibrarySystem(toolCategories[i][j], memberCollection);
                                            Tool newTool = new Tool(newToolName);
                                            tempLibrary.add(newTool);
                                            newTool.Quantity += newToolQuantityInt;
                                            Console.WriteLine("");
                                            Console.WriteLine($"{newTool.Name} has been added to the library, press any key to return to staff menu");
                                            Console.ReadKey();
                                        }
                                    }
                                }

                            }
                        }



                    }
                    else if (userInput == "2")
                    {
                        Console.Clear();
                        Console.WriteLine("Add Pieces to an Existing Tool");
                        Console.WriteLine("==================================");
                        for (int i = 0; i < categoryLabels.Length; i++)
                        {
                            Console.WriteLine($"{i + 1}: " + $"{categoryLabels[i]}");
                        }
                        Console.WriteLine("Select option from menu (0 to exit): ");
                        int toolCategoryInput = Int32.Parse(Console.ReadLine()) - 1;
                        Console.Clear();
                        Console.WriteLine(categoryLabels[toolCategoryInput]);
                        Console.WriteLine("===========================");

                        for (int j = 0; j < categoryLabelsJagged[toolCategoryInput].Length; j++)
                        {
                            Console.WriteLine($"{j + 1}: " + $"{categoryLabelsJagged[toolCategoryInput][j]}");
                        }
                        int toolTypeInput = Int32.Parse(Console.ReadLine()) - 1;
                        Console.Clear();
                        Console.WriteLine(categoryLabelsJagged[toolCategoryInput][toolTypeInput]);
                        Console.WriteLine("===========================");

                        for (int i = 0; i < toolCategories.Length; i++)
                        {
                            if (toolCategoryInput == i)
                            {
                                toolCategoryInput = i;
                            }
                        }
                        for (int j = 0; j < toolCategories[toolCategoryInput].Length; j++)
                        {
                            if (toolTypeInput == j)
                            {
                                toolTypeInput = j;
                            }
                        }
                        for (int i = 0; i < toolCategories[toolCategoryInput][toolTypeInput].toArray().Length; i++)
                        {
                            if (toolCategories[toolCategoryInput][toolTypeInput].toArray()[i] != null)
                            {
                                Console.WriteLine($"{i}: {toolCategories[toolCategoryInput][toolTypeInput].toArray()[i]}");
                                Console.WriteLine("===");

                            }
                        }
                        Console.WriteLine("Select the number of the tool you wish to add pieces to...");
                        int incrementTool = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("How many pieces would you like to add?");
                        int incrementAmount = Int32.Parse(Console.ReadLine());
                        ToolLibrarySystem tempLibrary = new ToolLibrarySystem(toolCategories[toolCategoryInput][toolTypeInput], memberCollection);
                        if ((tempLibrary.ToolCollection.toArray()[incrementTool].Quantity + incrementAmount) > toolCategories[toolCategoryInput][toolTypeInput].Capacity)
                        {
                            tempLibrary.ToolCollection.toArray()[incrementTool].Quantity += incrementAmount;
                            Console.WriteLine($"Successfully added {incrementAmount} pieces to the tool");
                            Console.WriteLine("Press 0 to return to staff menu");
                            if (Console.ReadLine() == "0")
                            {
                                staffMenuState = true;
                            }
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Cannot add pieces from tool, it is at maximum capacity, please press any key to return to staff menu");
                            if (Console.ReadLine() == "0")
                            {
                                staffMenuState = true;
                            }

                        }
                    }
                    else if (userInput == "3")
                    {
                        Console.Clear();
                        Console.WriteLine("Remove Pieces of an Existing Tool");
                        Console.WriteLine("==================================");
                        for (int i = 0; i < categoryLabels.Length; i++)
                        {
                            Console.WriteLine($"{i + 1}: " + $"{categoryLabels[i]}");
                        }
                        Console.WriteLine("Select option from menu (0 to exit): ");
                        int toolCategoryInput = Int32.Parse(Console.ReadLine()) - 1;
                        Console.Clear();
                        Console.WriteLine(categoryLabels[toolCategoryInput]);
                        Console.WriteLine("===========================");

                        for (int j = 0; j < categoryLabelsJagged[toolCategoryInput].Length; j++)
                        {
                            Console.WriteLine($"{j + 1}: " + $"{categoryLabelsJagged[toolCategoryInput][j]}");
                        }
                        int toolTypeInput = Int32.Parse(Console.ReadLine()) - 1;
                        Console.Clear();
                        Console.WriteLine(categoryLabelsJagged[toolCategoryInput][toolTypeInput]);
                        Console.WriteLine("===========================");

                        for (int i = 0; i < toolCategories.Length; i++)
                        {
                            if (toolCategoryInput == i)
                            {
                                toolCategoryInput = i;
                            }
                        }
                        for (int j = 0; j < toolCategories[toolCategoryInput].Length; j++)
                        {
                            if (toolTypeInput == j)
                            {
                                toolTypeInput = j;
                            }
                        }
                        for (int i = 0; i < toolCategories[toolCategoryInput][toolTypeInput].toArray().Length; i++)
                        {
                            if (toolCategories[toolCategoryInput][toolTypeInput].toArray()[i] != null)
                            {
                                Console.WriteLine($"{i}: {toolCategories[toolCategoryInput][toolTypeInput].toArray()[i]}");
                                Console.WriteLine("===");
                                
                            }
                        }                        
                        Console.WriteLine("Select the number of the tool you wish to remove pieces from...");
                        int incrementTool = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("How many pieces would you like to remove?");
                        int incrementAmount = Int32.Parse(Console.ReadLine());
                        ToolLibrarySystem tempLibrary = new ToolLibrarySystem(toolCategories[toolCategoryInput][toolTypeInput], memberCollection);
                        if ((tempLibrary.ToolCollection.toArray()[incrementTool].Quantity - incrementAmount) >= 0)
                        {
                            tempLibrary.ToolCollection.toArray()[incrementTool].Quantity -= incrementAmount;
                            Console.WriteLine($"Successfully removed {incrementAmount} pieces from the tool");
                            Console.WriteLine("Press 0 to return to staff menu");
                            if (Console.ReadLine() == "0")
                            {
                                staffMenuState = true;
                            }
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Cannot remove pieces from tool, it already has 0, or wil be reduced below 0, please press any key to return to staff menu");
                            if (Console.ReadLine() == "0")
                            {
                                staffMenuState = true;
                            }

                        }                                                                
                    }                
                    else if (userInput == "4")
                    {
                        Console.Clear();
                        Console.WriteLine("Add a new member");
                        Console.WriteLine("================");
                        Console.WriteLine("Please enter a first name");
                        string memberFirstName = Console.ReadLine();
                        Console.WriteLine("Please enter a last name");
                        string memberLastName = Console.ReadLine();
                        Console.WriteLine("Please enter a mobile number");
                        string memberPhone = Console.ReadLine();
                        Console.WriteLine("Please enter a four digit pin");
                        string memberPin = Console.ReadLine();
                        Member newMember = new Member(memberFirstName, memberLastName, memberPhone, memberPin);
                        memberCollection.add(newMember);
                        Console.WriteLine($"You have successfuly added: {memberFirstName}" + " " + $"{memberLastName}" + " to the system");
                        Console.WriteLine("Press any key to return to staff menu");
                        Console.ReadKey();
                    }
                    else if (userInput == "5")
                    {
                        Console.Clear();
                        Console.WriteLine("Delete a member");
                        Console.WriteLine("===============");
                        Console.WriteLine("Please enter the first name of the member you wish to delete");
                        string deleteFirst = Console.ReadLine();
                        Console.WriteLine("Please enter the last name of the member you wish to delete");
                        string deleteLast = Console.ReadLine();
                        Console.WriteLine("Please enter the phone number of the member you wish to delete");
                        string deleteNumber = Console.ReadLine();
                        Console.WriteLine("Please enter the pin of the member you wish to delete");
                        string deletePin = Console.ReadLine();
                        Member deleteMember = new Member(deleteFirst, deleteLast, deleteNumber, deletePin);
                        memberCollection.delete(deleteMember);
                        if (memberCollection.search(deleteMember) == false)
                        {
                            Console.WriteLine($"You have successfuly deleted: {deleteFirst}" + " " + $"{deleteLast}" + " from the system");
                            Console.WriteLine("Press any key to return to staff menu");
                            Console.ReadKey();
                        }                        

                    }
                    else if (userInput == "6")
                    {
                        Console.Clear();
                        Console.WriteLine("Find a member's contact number");
                        Console.WriteLine("===============");
                        Console.WriteLine("Please enter the first name of the member");
                        string memberFirst = Console.ReadLine();
                        Console.WriteLine("Please enter the last name of the member");
                        string memberLast = Console.ReadLine();
                        Console.WriteLine(memberFirst + " " + memberLast + "'s number" + ": " + memberCollection.FindNumber(memberFirst, memberLast));
                        Console.WriteLine("Press any key to return to staff menu");
                        Console.ReadLine();

                    }

                }
            }
            
            
            void MemberMenu()
            {
                bool memberMenuState = true;
                while (memberMenuState)
                {
                    Console.Clear();
                    Console.WriteLine("Welcome to the Tool Library");
                    Console.WriteLine("================Member Menu================");
                    Console.WriteLine("1. Display all the tools of a tool type");
                    Console.WriteLine("2. Borrow a tool");
                    Console.WriteLine("3. Return a tool");
                    Console.WriteLine("4. List all the tools that I am renting");
                    Console.WriteLine("5. Display top three (3) most frequently rented tools");
                    Console.WriteLine("0. Return to the main menu");
                    Console.WriteLine("==========================================");

                    string memberMenuInput = Console.ReadLine();
                    if (memberMenuInput == "0") { memberMenuState = false; Console.Clear(); }

                    // Display Tools by Type
                    if (memberMenuInput == "1")
                    {
                        Console.Clear();
                        Console.WriteLine("Display of Tools by Type");
                        Console.WriteLine("========================");                        
                        for (int i = 0; i < categoryLabels.Length; i++)
                        {
                            Console.WriteLine($"{i + 1}: " + $"{categoryLabels[i]}");
                        }
                        Console.WriteLine("Select option from menu (0 to exit): ");
                        int toolCategoryInput = Int32.Parse(Console.ReadLine()) - 1;
                        Console.Clear();
                        Console.WriteLine(categoryLabels[toolCategoryInput]);
                        Console.WriteLine("===========================");

                        for (int j = 0; j < categoryLabelsJagged[toolCategoryInput].Length; j++)
                        {
                            Console.WriteLine($"{j + 1}: " + $"{categoryLabelsJagged[toolCategoryInput][j]}");
                        }
                        int toolTypeInput = Int32.Parse(Console.ReadLine()) - 1;
                        Console.Clear();
                        Console.WriteLine(categoryLabelsJagged[toolCategoryInput][toolTypeInput]);
                        Console.WriteLine("===========================");

                        for (int i = 0; i < toolCategories[toolCategoryInput][toolTypeInput].toArray().Length; i++)
                        {
                            if (toolCategories[toolCategoryInput][toolTypeInput].toArray()[i] != null)
                            {
                                Console.WriteLine(toolCategories[toolCategoryInput][toolTypeInput].toArray()[i]);
                                Console.WriteLine("===");
                            }
                            
                        }
                        Console.WriteLine("Pess any key to return to member menu");
                        Console.ReadKey();
                    }
                    if (memberMenuInput == "2")
                    {
                        Console.Clear();
                        Console.WriteLine("=== Borrow a Tool ===");
                        Console.WriteLine("=====================");
                        //Console.WriteLine("Please enter your first name");
                        //string borrowerFirst = Console.ReadLine();
                        //Console.WriteLine("Please enter your last name");
                        //string borrowerLast = Console.ReadLine();
                        //Console.WriteLine("Please enter your phone number");
                        //string borrowerNum = Console.ReadLine();
                        //Member borrowingMember = memberCollection.ConfirmMember(borrowerFirst, borrowerLast, borrowerNum);

                        
                        Console.WriteLine("Please enter the name of the tool you wish to borrow");
                        string desiredToolName = Console.ReadLine();
                        Tool desiredTool = new Tool("desired");
                        int catIndex = 0; ;
                        int typeIndex = 0; ;
                        

                        for (int i = 0; i < toolCategories.Length; i++)
                        {
                            for (int j = 0; j < toolCategories[i].Length; j++)
                            {
                                for (int t = 0; t < toolCategories[i][j].toArray().Length; t++)
                                {
                                    if (toolCategories[i][j].toArray()[t] != null)
                                    {
                                        if (desiredToolName == (toolCategories[i][j].toArray()[t]).Name)
                                        {
                                            desiredTool = (toolCategories[i][j].toArray()[t]);

                                            ToolLibrarySystem tempLibrary = new ToolLibrarySystem(toolCategories[catIndex][typeIndex], memberCollection);
                                            tempLibrary.borrowTool(persistentMember, desiredTool);
                                            Console.WriteLine($"You have successfully borrowed {desiredTool.Name}");

                                            //desiredTool = toolCategories[i][j].ConfirmTool(desiredToolName);
                                            break;
                                            

                                        }
                                    }
                                    
                                }
                            }
                        }
                                                                                         

                        Console.WriteLine("Press any key to return to member menu");
                        Console.ReadLine();

                    }
                    // Return Tool
                    else if (memberMenuInput == "3")
                    {
                        Console.Clear();
                        Console.WriteLine("=== Return a Tool ===");
                        Console.WriteLine("=====================");                        
                        Console.WriteLine("Please enter the name of the tool you wish to return");
                        string desiredToolName = Console.ReadLine();
                        Tool desiredTool;


                        for (int i = 0; i < toolCategories.Length; i++)
                        {
                            for (int j = 0; j < toolCategories[i].Length; j++)
                            {
                                for (int t = 0; t < toolCategories[i][j].toArray().Length; t++)
                                {
                                    if (toolCategories[i][j].toArray()[t] != null)
                                    {
                                        if (desiredToolName == (toolCategories[i][j].toArray()[t]).Name)
                                        {
                                            desiredTool = toolCategories[i][j].ConfirmTool(desiredToolName);
                                            ToolLibrarySystem tempLibrary = new ToolLibrarySystem(toolCategories[i][j], memberCollection);
                                            tempLibrary.returnTool(persistentMember, desiredTool);
                                            Console.WriteLine($"You have successfully returned:\n{desiredTool}\n");
                                            Console.WriteLine("Please press any key to return to member menu");

                                        }

                                    }

                                }
                            }
                        }
                        Console.ReadKey();

                    }
                    else if(memberMenuInput == "4")
                    {
                        Console.Clear();
                        Console.WriteLine("=== Displaying Borrowed Tools ===");
                        Console.WriteLine("=================================");
                        for (int i = 0; i < persistentMember.BorrowedTools.toArray().Length; i++)
                        {
                            if (persistentMember.BorrowedTools.toArray()[i] != null)
                            {
                                Console.WriteLine(persistentMember.BorrowedTools.toArray()[i]);
                                Console.WriteLine("===");
                            }
                        }
                        Console.WriteLine("Press any key to return to member menu");
                        Console.ReadKey();
                    }
                    else if(memberMenuInput == "5")
                    {
                        ToolLibrarySystem tempLibrary = new ToolLibrarySystem();
                        tempLibrary.AllTools = toolCategories;                        

                        Console.Clear();
                        Console.WriteLine("=== Top Three Most Borrowed Tools ===");
                        Console.WriteLine("=====================================");
                        //tempLibrary.displayTopTHree();
                        Tool[] unsortedArray = HSTest.CombinedToolsArray(toolCategories);
                        Tool[] sortedArray = HeapSortAlgorithm.HeapSort(unsortedArray);

                        for (int i = 0; i < sortedArray.Length; i++)
                        {
                            if (lineTrimmers.toArray()[i] != null)
                            {
                                Console.WriteLine($"#{i+1}: "+ sortedArray[i].Name + $"\nTimes Borrowed: {sortedArray[i].NoBorrowings}\n===");
                            }

                        }

                        Console.ReadKey();

                    }

                }

                 
            }
            MainMenu();


            Console.ReadLine();
        }
    }
}
