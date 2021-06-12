#include "QBle.h"
#include "QTypes.h"
#include "QDisplay.h"

#include <Particle.h>

#define QUASAR_THUMB A1
#define QUASAR_INDEX A0
#define QUASAR_MICROBUTTON D6
#define QUASAR_SENSOR_FLEXED 2500
#define QUASAR_MAX_GESTURES 10

namespace Quasar
{
    struct GestureData
    {
        bool Thumb;
        bool Index;
        bool Middle;
        bool Ring;
        bool Little;
    };

    void GestureThread() 
    {         
        auto characteristic = GetBleData()->GestureCharacteristic;
        bool gesturePending = false;
        GestureData gestures[QUASAR_MAX_GESTURES];
        int gestureId = 0;
        
        while (true) 
        {
            if (gesturePending) { gestureId = 0; }
        
            while (gesturePending)
	        {
                bool thumb = analogRead(QUASAR_THUMB) > QUASAR_SENSOR_FLEXED;
                bool index = analogRead(QUASAR_INDEX) > QUASAR_SENSOR_FLEXED;

                if (thumb == false && index == false) break;

                if (gestureId == 9) break;

                gestures[gestureId].Thumb = thumb;
                gestures[gestureId].Index = index; 

                Serial.printf("%d %d\n", thumb, index);

                gestureId++;
                
		        delay(500);
	        }

        
            if (gesturePending)
	        {
		        gesturePending = false;
                SetGestureChar(gestures, sizeof(GestureData) * (gestureId + 1));
	        }

            gesturePending = true;
        }
    } 
    static Thread s_GestureThread("gesture_thread", GestureThread);
}
