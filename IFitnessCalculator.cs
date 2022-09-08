namespace ega_lab1;

public interface IFitnessCalculator<TPreimage, TImage>
{
	public TImage Calculate(TPreimage preimage);
}
