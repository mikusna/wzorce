using System;

public class OrderProcessor
{
    public void ProcessOrders()
    {
        Console.WriteLine("Processing orders.");
    }
}

public class InventoryManager
{
    public void ManageInventory()
    {
        Console.WriteLine("Managing inventory.");
    }
}

public class DeliveryCoordinator
{
    public void CoordinateDeliveries()
    {
        Console.WriteLine("Coordinating deliveries.");
    }
}

public class ReturnHandler
{
    public void HandleReturns()
    {
        Console.WriteLine("Handling returns.");
    }
}

public class WarehouseManager
{
    private readonly OrderProcessor _orderProcessor;
    private readonly InventoryManager _inventoryManager;
    private readonly DeliveryCoordinator _deliveryCoordinator;
    private readonly ReturnHandler _returnHandler;

    public WarehouseManager()
    {
        _orderProcessor = new OrderProcessor();
        _inventoryManager = new InventoryManager();
        _deliveryCoordinator = new DeliveryCoordinator();
        _returnHandler = new ReturnHandler();
    }

    public void ProcessOrders()
    {
        _orderProcessor.ProcessOrders();
    }

    public void ManageInventory()
    {
        _inventoryManager.ManageInventory();
    }

    public void CoordinateDeliveries()
    {
        _deliveryCoordinator.CoordinateDeliveries();
    }

    public void HandleReturns()
    {
        _returnHandler.HandleReturns();
    }
}

class Program
{
    static void Main(string[] args)
    {
        WarehouseManager warehouseManager = new WarehouseManager();

        warehouseManager.ProcessOrders();
        warehouseManager.ManageInventory();
        warehouseManager.CoordinateDeliveries();
        warehouseManager.HandleReturns();

        Console.ReadKey();
    }
}
