using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulConverter
{
    public class Recipes : ModSystem
    {
        public override void AddRecipes()
        {
            // Light to Night
            Recipe recipe = Recipe.Create(ItemID.SoulofLight);
            recipe.AddIngredient(ItemID.SoulofNight, 1);
            recipe.AddTile(TileID.DemonAltar);
            recipe.Register();

            // Night to Light
            recipe = Recipe.Create(ItemID.SoulofNight);
            recipe.AddIngredient(ItemID.SoulofLight, 1);
            recipe.AddTile(TileID.DemonAltar);
            recipe.Register();
        }
    }
}