using UnityEngine;

public class GuiCoords
{
    public Rect inventorySlot1TexRect;
    public Rect inventorySlot2TexRect;
    public Rect inventorySlot3TexRect;
    public Rect inventorySlot4TexRect;
    public Rect inventorySlot5TexRect;
    public Rect inventorySlot6TexRect;
    public Rect inventorySlot7TexRect;
    public Rect inventorySlot8TexRect;
    public Rect inventorySlot9TexRect;
    public Rect inventorySlot10TexRect;
    public Rect inventorySlot11TexRect;
    public Rect inventorySlot12TexRect;
    public Rect inventorySlot13TexRect;
    public Rect inventorySlot14TexRect;
    public Rect inventorySlot15TexRect;
    public Rect inventorySlot16TexRect;
    public Rect[] inventorySlotRects;

    public Rect storageInventorySlot1TexRect;
    public Rect storageInventorySlot2TexRect;
    public Rect storageInventorySlot3TexRect;
    public Rect storageInventorySlot4TexRect;
    public Rect storageInventorySlot5TexRect;
    public Rect storageInventorySlot6TexRect;
    public Rect storageInventorySlot7TexRect;
    public Rect storageInventorySlot8TexRect;
    public Rect storageInventorySlot9TexRect;
    public Rect storageInventorySlot10TexRect;
    public Rect storageInventorySlot11TexRect;
    public Rect storageInventorySlot12TexRect;
    public Rect storageInventorySlot13TexRect;
    public Rect storageInventorySlot14TexRect;
    public Rect storageInventorySlot15TexRect;
    public Rect storageInventorySlot16TexRect;
    public Rect[] storageInventorySlotRects;

    public GuiCoords()
    {
        //ASPECT RATIO
        float screenHeight = Screen.height;
        float screenWidth = Screen.width;
        if (screenWidth / screenHeight < 1.7f)
        {
            screenHeight = (screenHeight * 0.75f);
        }

        inventorySlot1TexRect = new Rect((screenWidth * 0.722f), (screenHeight * 0.35f), (screenWidth * 0.029f), (screenHeight * 0.055f));
        inventorySlot2TexRect = new Rect((screenWidth * 0.774f), (screenHeight * 0.35f), (screenWidth * 0.029f), (screenHeight * 0.055f));
        inventorySlot3TexRect = new Rect((screenWidth * 0.828f), (screenHeight * 0.35f), (screenWidth * 0.029f), (screenHeight * 0.055f));
        inventorySlot4TexRect = new Rect((screenWidth * 0.882f), (screenHeight * 0.35f), (screenWidth * 0.029f), (screenHeight * 0.055f));
        inventorySlot5TexRect = new Rect((screenWidth * 0.722f), (screenHeight * 0.445f), (screenWidth * 0.029f), (screenHeight * 0.055f));
        inventorySlot6TexRect = new Rect((screenWidth * 0.774f), (screenHeight * 0.445f), (screenWidth * 0.029f), (screenHeight * 0.055f));
        inventorySlot7TexRect = new Rect((screenWidth * 0.828f), (screenHeight * 0.445f), (screenWidth * 0.029f), (screenHeight * 0.055f));
        inventorySlot8TexRect = new Rect((screenWidth * 0.882f), (screenHeight * 0.445f), (screenWidth * 0.029f), (screenHeight * 0.055f));
        inventorySlot9TexRect = new Rect((screenWidth * 0.722f), (screenHeight * 0.535f), (screenWidth * 0.029f), (screenHeight * 0.055f));
        inventorySlot10TexRect = new Rect((screenWidth * 0.774f), (screenHeight * 0.535f), (screenWidth * 0.029f), (screenHeight * 0.055f));
        inventorySlot11TexRect = new Rect((screenWidth * 0.828f), (screenHeight * 0.535f), (screenWidth * 0.029f), (screenHeight * 0.055f));
        inventorySlot12TexRect = new Rect((screenWidth * 0.882f), (screenHeight * 0.535f), (screenWidth * 0.029f), (screenHeight * 0.055f));
        inventorySlot13TexRect = new Rect((screenWidth * 0.722f), (screenHeight * 0.625f), (screenWidth * 0.029f), (screenHeight * 0.055f));
        inventorySlot14TexRect = new Rect((screenWidth * 0.774f), (screenHeight * 0.625f), (screenWidth * 0.029f), (screenHeight * 0.055f));
        inventorySlot15TexRect = new Rect((screenWidth * 0.828f), (screenHeight * 0.625f), (screenWidth * 0.029f), (screenHeight * 0.055f));
        inventorySlot16TexRect = new Rect((screenWidth * 0.882f), (screenHeight * 0.625f), (screenWidth * 0.029f), (screenHeight * 0.055f));

        inventorySlotRects = new Rect[16];
        inventorySlotRects[0] = inventorySlot1TexRect;
        inventorySlotRects[1] = inventorySlot2TexRect;
        inventorySlotRects[2] = inventorySlot3TexRect;
        inventorySlotRects[3] = inventorySlot4TexRect;
        inventorySlotRects[4] = inventorySlot5TexRect;
        inventorySlotRects[5] = inventorySlot6TexRect;
        inventorySlotRects[6] = inventorySlot7TexRect;
        inventorySlotRects[7] = inventorySlot8TexRect;
        inventorySlotRects[8] = inventorySlot9TexRect;
        inventorySlotRects[9] = inventorySlot10TexRect;
        inventorySlotRects[10] = inventorySlot11TexRect;
        inventorySlotRects[11] = inventorySlot12TexRect;
        inventorySlotRects[12] = inventorySlot13TexRect;
        inventorySlotRects[13] = inventorySlot14TexRect;
        inventorySlotRects[14] = inventorySlot15TexRect;
        inventorySlotRects[15] = inventorySlot16TexRect;

        storageInventorySlot1TexRect = new Rect((screenWidth * 0.322f), (screenHeight * 0.35f), (screenWidth * 0.029f), (screenHeight * 0.055f));
        storageInventorySlot2TexRect = new Rect((screenWidth * 0.374f), (screenHeight * 0.35f), (screenWidth * 0.029f), (screenHeight * 0.055f));
        storageInventorySlot3TexRect = new Rect((screenWidth * 0.428f), (screenHeight * 0.35f), (screenWidth * 0.029f), (screenHeight * 0.055f));
        storageInventorySlot4TexRect = new Rect((screenWidth * 0.482f), (screenHeight * 0.35f), (screenWidth * 0.029f), (screenHeight * 0.055f));
        storageInventorySlot5TexRect = new Rect((screenWidth * 0.322f), (screenHeight * 0.445f), (screenWidth * 0.029f), (screenHeight * 0.055f));
        storageInventorySlot6TexRect = new Rect((screenWidth * 0.374f), (screenHeight * 0.445f), (screenWidth * 0.029f), (screenHeight * 0.055f));
        storageInventorySlot7TexRect = new Rect((screenWidth * 0.428f), (screenHeight * 0.445f), (screenWidth * 0.029f), (screenHeight * 0.055f));
        storageInventorySlot8TexRect = new Rect((screenWidth * 0.482f), (screenHeight * 0.445f), (screenWidth * 0.029f), (screenHeight * 0.055f));
        storageInventorySlot9TexRect = new Rect((screenWidth * 0.322f), (screenHeight * 0.535f), (screenWidth * 0.029f), (screenHeight * 0.055f));
        storageInventorySlot10TexRect = new Rect((screenWidth * 0.374f), (screenHeight * 0.535f), (screenWidth * 0.029f), (screenHeight * 0.055f));
        storageInventorySlot11TexRect = new Rect((screenWidth * 0.428f), (screenHeight * 0.535f), (screenWidth * 0.029f), (screenHeight * 0.055f));
        storageInventorySlot12TexRect = new Rect((screenWidth * 0.482f), (screenHeight * 0.535f), (screenWidth * 0.029f), (screenHeight * 0.055f));
        storageInventorySlot13TexRect = new Rect((screenWidth * 0.322f), (screenHeight * 0.625f), (screenWidth * 0.029f), (screenHeight * 0.055f));
        storageInventorySlot14TexRect = new Rect((screenWidth * 0.374f), (screenHeight * 0.625f), (screenWidth * 0.029f), (screenHeight * 0.055f));
        storageInventorySlot15TexRect = new Rect((screenWidth * 0.428f), (screenHeight * 0.625f), (screenWidth * 0.029f), (screenHeight * 0.055f));
        storageInventorySlot16TexRect = new Rect((screenWidth * 0.482f), (screenHeight * 0.625f), (screenWidth * 0.029f), (screenHeight * 0.055f));

        storageInventorySlotRects = new Rect[16];
        storageInventorySlotRects[0] = storageInventorySlot1TexRect;
        storageInventorySlotRects[1] = storageInventorySlot2TexRect;
        storageInventorySlotRects[2] = storageInventorySlot3TexRect;
        storageInventorySlotRects[3] = storageInventorySlot4TexRect;
        storageInventorySlotRects[4] = storageInventorySlot5TexRect;
        storageInventorySlotRects[5] = storageInventorySlot6TexRect;
        storageInventorySlotRects[6] = storageInventorySlot7TexRect;
        storageInventorySlotRects[7] = storageInventorySlot8TexRect;
        storageInventorySlotRects[8] = storageInventorySlot9TexRect;
        storageInventorySlotRects[9] = storageInventorySlot10TexRect;
        storageInventorySlotRects[10] = storageInventorySlot11TexRect;
        storageInventorySlotRects[11] = storageInventorySlot12TexRect;
        storageInventorySlotRects[12] = storageInventorySlot13TexRect;
        storageInventorySlotRects[13] = storageInventorySlot14TexRect;
        storageInventorySlotRects[14] = storageInventorySlot15TexRect;
        storageInventorySlotRects[15] = storageInventorySlot16TexRect;
    }
}


