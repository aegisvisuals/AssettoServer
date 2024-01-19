﻿using FluentValidation;
using JetBrains.Annotations;

namespace AutoModerationPlugin;

[UsedImplicitly]
public class AutoModerationConfigurationValidator : AbstractValidator<AutoModerationConfiguration>
{
    public AutoModerationConfigurationValidator()
    {
        RuleFor(cfg => cfg.WrongWayPenalty).NotNull().ChildRules(wwk =>
        {
            wwk.RuleFor(w => w.DurationSeconds).GreaterThanOrEqualTo(0);
            wwk.RuleFor(w => w.MinimumSpeedKph).GreaterThanOrEqualTo(0);
            wwk.RuleFor(w => w.PitsBeforeKick).GreaterThanOrEqualTo(0);
        });
        RuleFor(cfg => cfg.NoLightsPenalty).NotNull().ChildRules(nlk =>
        {
            nlk.RuleFor(n => n.DurationSeconds).GreaterThanOrEqualTo(0);
            nlk.RuleFor(n => n.MinimumSpeedKph).GreaterThanOrEqualTo(0);
            nlk.RuleFor(n => n.PitsBeforeKick).GreaterThanOrEqualTo(0);
            nlk.RuleFor(n => n.IgnoreSeconds).GreaterThanOrEqualTo(0);
        });
        RuleFor(cfg => cfg.BlockingRoadPenalty).NotNull().ChildRules(brk =>
        {
            brk.RuleFor(b => b.DurationSeconds).GreaterThanOrEqualTo(0);
            brk.RuleFor(b => b.MaximumSpeedKph).GreaterThanOrEqualTo(0);
            brk.RuleFor(b => b.PitsBeforeKick).GreaterThanOrEqualTo(0);
        });
    }
}
