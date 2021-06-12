#ifndef QUASAR_DISPLAY_H
#define QUASAR_DISPLAY_H

#include <Adafruit_SSD1306.h>

namespace Quasar
{
    typedef void(*DisplayPresenter)(Adafruit_SSD1306* pDisplay);

    void InitDisplay();
    void PresentDisplay();
    void SetPresenter(DisplayPresenter pPresenter);
}

#endif