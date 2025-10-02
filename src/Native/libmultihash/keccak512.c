#include "keccak512.h"

#include "sha3/sph_types.h"
#include "sha3/sph_keccak.h"


void keccak512_hash(const char* input, char* output, uint32_t size)
{
    sph_keccak512_context ctx_keccak;
    sph_keccak512_init(&ctx_keccak);
    sph_keccak512 (&ctx_keccak, input, size);//80);
    sph_keccak512_close(&ctx_keccak, output);
}
