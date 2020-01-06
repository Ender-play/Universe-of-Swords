using Terraria.ID;
using Terraria.ModLoader;

namespace WeaponsPlus.Items
{
	public class TheSword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("The Sword"); .
			Tooltip.SetDefault("Sword of insane!");
		}

		public override void SetDefaults() 
		{
			item.damage = 60000;
			item.melee = true;
			item.expert = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 0;
			item.value = 10000;
			item.UseSound = SoundID.Item1;
			item.autoReuse = false;
			item.rare = 12;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.ChlorophyteBar, 30);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}