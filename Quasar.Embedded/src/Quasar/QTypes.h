#ifndef QUASAR_TYPES_H
#define QUASAR_TYPES_H

#include <memory>

namespace Quasar
{
    template<typename T>
    using Instance = std::unique_ptr<T>;

    template<typename T, typename ...TArgs>
    constexpr Instance<T> CreateInstance(TArgs... args)
    {
        return std::make_unique<T>(std::forward<TArgs>(args)...);
    }

    template<typename T>
    using SharedInstance = std::shared_ptr<T>;

    template<typename T, typename ...TArgs>
    constexpr SharedInstance<T> CreateSharedInstance(TArgs... args)
    {
        return std::make_shared<T>(std::forward<TArgs>(args)...);
    }

    #define QUASAR_THREAD(x, y) void x() { while (true) y} \
                            static Thread s_##x(#x, x)
    #define QUASAR_THREAD_INIT(x, y, z) void x() { y while (true) z} \
                            static Thread s_##x(#x, x)
}

#endif