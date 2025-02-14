#pragma once

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Wempty-body"
#pragma clang diagnostic ignored "-Wswitch"
#endif

#include <altv-cpp-api/SDK.h>
#include "position.h"
#include "rotation.h"

#ifdef __clang__
#pragma clang diagnostic pop
#endif

#ifdef __cplusplus
extern "C"
{
#endif
EXPORT void Event_Cancel(alt::CEvent* event);
EXPORT void Event_PlayerBeforeConnect_Cancel(alt::CEvent* event, const char* reason);
EXPORT uint8_t Event_WasCancelled(alt::CEvent* event);
#ifdef __cplusplus
}
#endif
