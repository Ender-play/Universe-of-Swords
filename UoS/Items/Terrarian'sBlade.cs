using Terraria.ID;
using Terraria.ModLoader;

namespace WeaponsPlus.Items
{
	public class TerrarianBlade : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("Terrarian's Blade"); .
			Tooltip.SetDefault("The good sword");
		}

		public override void SetDefaults() 
		{
			item.damage = 80239;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 2;
			item.knockBack = 4000;
			item.value = 10000;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.rare = 5;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.HellstoneBar, 50);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}