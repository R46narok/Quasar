#include "QDisplay.h"

#include <spi.h>
#include <wire.h>
#include <Adafruit_GFX.h>

#define QUASAR_OLED_RESET 4

namespace Quasar
{
    static Adafruit_SSD1306 sDisplay(QUASAR_OLED_RESET);
    static DisplayPresenter spPresenter = nullptr;

    void InitDisplay()
    {
        sDisplay.begin(SSD1306_SWITCHCAPVCC, 0x3C);
        sDisplay.clearDisplay();
    }

    void PresentDisplay()
    {
        sDisplay.clearDisplay();
        sDisplay.setTextSize(2);
        sDisplay.setTextColor(WHITE);
        sDisplay.setCursor(0, 0);

        // TODO: Display stuff here

        if (spPresenter != nullptr)
        {
            spPresenter(&sDisplay);
        }

        sDisplay.display();
    }

    void SetPresenter(DisplayPresenter pPresenter)
    {
        spPresenter = pPresenter;
    }
}